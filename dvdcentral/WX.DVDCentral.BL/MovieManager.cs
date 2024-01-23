using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.DVDCentral.PL;
using WX.DVDCentral.BL.Models;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Update;
using Newtonsoft.Json.Linq;
using System.Data;
using Microsoft.Data.SqlClient.Server;
using System.IO;

namespace WX.DVDCentral.BL
{
    public static class MovieManager
    {
        private const string Message = "Row does not exist";

        public static int Insert(Movie movie, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblMovie row = new tblMovie();

                    // The Ternary Operator
                    row.Id = dc.tblMovies.Any() ? dc.tblMovies.Max(s => s.Id) + 1 : 1;

                    row.Title = movie.Title;
                    row.Description = movie.Description;
                    row.Cost = movie.Cost;
                    row.RatingId = movie.RatingId;
                    row.FormatId = movie.FormatId;
                    row.DirectorId = movie.DirectorId;
                    row.InStkQty = movie.InStkQty;
                    row.ImagePath = movie.ImagePath;

                    // Backfilling the ID
                    movie.Id = row.Id;

                    dc.tblMovies.Add(row);
                    results = dc.SaveChanges();

                    if (rollback) dbContextTransaction.Rollback();
                }

                return results;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Movie> Load()
        {
            // SELECT * FROM TBLMovie
            try
            {
                List<Movie> rows = new List<Movie>();

                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    var movies = (from m in dc.tblMovies
                                  join d in dc.tblDirectors on m.DirectorId equals d.Id
                                  join f in dc.tblFormats on m.FormatId equals f.Id
                                  join r in dc.tblRatings on m.RatingId equals r.Id
                                  join mg in dc.tblMovieGenres on m.Id equals mg.Id
                                  orderby m.Title
                                  select new
                                  {
                                      MovieId = m.Id,
                                      RatingId = r.Id,
                                      DirectorId = d.Id,
                                      FormatId = f.Id,
                                      GenreId = mg.Id,
                                      m.Title,
                                      m.Description,
                                      m.Cost,
                                      FormatDescription = f.Description,
                                      RatingDescription = r.Description,
                                      m.InStkQty,
                                      m.ImagePath,
                                      d.FirstName,
                                      d.LastName,
                                  })
                                  .Distinct()
                                  .ToList();

                    movies.ForEach(m => rows.Add(new Models.Movie
                    {
                        Id = m.MovieId,
                        RatingId = m.RatingId,
                        DirectorId = m.DirectorId,
                        FormatId = m.FormatId,
                        GenreId= m.GenreId,
                        Title = m.Title,
                        Description = m.Description,
                        InStkQty = m.InStkQty,
                        ImagePath = m.ImagePath,
                        Cost= m.Cost,
                        Rating = m.RatingDescription,
                        Format = m.FormatDescription,
                        FullName = m.LastName + ", " + m.FirstName
                    }));
                }
                return rows;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static Movie LoadbyId(int id)
        {
            try
            {
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    var row = (from m in dc.tblMovies
                                  join d in dc.tblDirectors on m.DirectorId equals d.Id
                                  join f in dc.tblFormats on m.FormatId equals f.Id
                                  join r in dc.tblRatings on m.RatingId equals r.Id
                                  join mg in dc.tblMovieGenres on m.Id equals mg.Id
                                  where m.Id == id
                                  select new
                                  {
                                      MovieId = m.Id,
                                      RatingId = r.Id,
                                      DirectorId = d.Id,
                                      FormatId = f.Id,
                                      GenreId = mg.Id,
                                      m.Title,
                                      m.Description,
                                      m.Cost,
                                      FormatDescription = f.Description,
                                      RatingDescription = r.Description,
                                      m.InStkQty,
                                      m.ImagePath,
                                      d.FirstName,
                                      d.LastName,
                                  }).FirstOrDefault();
                    if(row != null)
                    {
                        return new Movie
                        {
                            Id = row.MovieId,
                            RatingId = row.RatingId,
                            DirectorId = row.DirectorId,
                            FormatId = row.FormatId,
                            GenreId = row.GenreId,
                            Title= row.Title,
                            Description= row.Description,
                            Cost= row.Cost,
                            Format = row.FormatDescription,
                            Rating = row.RatingDescription,
                            InStkQty= row.InStkQty,
                            ImagePath = row.ImagePath,
                            FullName = row.FirstName + "" + row.LastName,
                        };
                    }
                    else
                    {
                        throw new Exception(Message);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static int Update(Movie movie, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblMovie row = dc.tblMovies.Where(s => s.Id == movie.Id).FirstOrDefault();

                    if (row != null)
                    {
                        row.Title = movie.Title;
                        row.Description = movie.Description;
                        row.Cost = movie.Cost;
                        row.RatingId = movie.RatingId;
                        row.FormatId = movie.FormatId;
                        row.DirectorId = movie.DirectorId;
                        row.InStkQty = movie.InStkQty;
                        row.ImagePath = movie.ImagePath;

                        results = dc.SaveChanges();

                        if (rollback) dbContextTransaction.Rollback();
                    }
                    else
                    {
                        throw new Exception(Message);
                    }
                }

                return results;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static int Delete(int id, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblMovie row = dc.tblMovies.Where(s => s.Id == id).FirstOrDefault();

                    if (row != null)
                    {
                        dc.tblMovies.Remove(row);
                        results = dc.SaveChanges();

                        if (rollback) dbContextTransaction.Rollback();
                    }
                    else
                    {
                        throw new Exception(Message);
                    }
                }
                return results;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<Movie> LoadByGenreId(int? genreId = null)
        {
            try
            {
                List<BL.Models.Movie> rows = new List<BL.Models.Movie>();

                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    var movies = (from m in dc.tblMovies
                                  join d in dc.tblDirectors on m.DirectorId equals d.Id
                                  join f in dc.tblFormats on m.FormatId equals f.Id
                                  join r in dc.tblRatings on m.RatingId equals r.Id
                                  join mg in dc.tblMovieGenres on m.Id equals mg.Id
                                  where mg.GenreId == genreId || genreId == null
                                  orderby m.Title
                                  select new
                                  {
                                      MovieId = m.Id,
                                      RatingId = r.Id,
                                      DirectorId = d.Id,
                                      FormatId = f.Id,
                                      m.Title,
                                      m.Description,
                                      FormatDescription = f.Description,
                                      RatingDescription = r.Description,
                                      m.InStkQty,
                                      m.ImagePath,
                                      d.FirstName,
                                      d.LastName,
                                      m.Cost,
                                  }).ToList();
                    movies.ForEach(m => rows.Add(new Models.Movie
                    {
                        Id = m.MovieId,
                        RatingId = m.RatingId,
                        DirectorId = m.DirectorId,
                        FormatId = m.FormatId,
                        Title = m.Title,
                        Description = m.Description,
                        InStkQty = m.InStkQty,
                        ImagePath = m.ImagePath,
                        Rating = m.RatingDescription,
                        Format = m.FormatDescription,
                        FullName = m.LastName + ", " + m.FirstName,
                        Cost = m.Cost,
                    }));
                }
                return rows;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
