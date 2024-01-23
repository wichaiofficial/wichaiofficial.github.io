using gg.ggFaqs.BL.Models;
using gg.ggFaqs.PL;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gg.ggFaqs.BL
{
    public static class GenreManager
    {
        public static List<Genre> Load()
        {
            try
            {
                List<Genre> rows = new List<Genre>();

                using (ggEntities dc = new ggEntities())
                {
                    var genres = (from p in dc.tblGenres
                                  orderby p.Id
                                  select new
                                  {
                                      p.Id,
                                      p.Genre,
                                      p.GenreDescription
                                  }).ToList();

                    genres.ForEach(p => rows.Add(new Genre
                    {
                        Id = p.Id,
                        Name = p.Genre,
                        Description = p.GenreDescription
                    }));
                }
                return rows;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static Genre LoadById(int id)
        {
            try
            {
                using (ggEntities dc = new ggEntities())
                {
                    tblGenre row = dc.tblGenres.Where(p => p.Id == id).FirstOrDefault();

                    if (row != null)
                    {
                        return new Genre
                        {
                            Id = row.Id,
                            Name = row.Genre,
                            Description = row.GenreDescription
                        };
                    }
                    else
                    {
                        throw new Exception("Row could not be found");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int Insert(Genre genre, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblGenre row = new tblGenre();

                    row.Id = dc.tblGenres.Any() ? dc.tblGenres.Max(s => s.Id) + 1 : 1;
                    row.Genre = genre.Name;
                    row.GenreDescription = genre.Description;
                    row.Id = genre.Id;

                    dc.tblGenres.Add(row);
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

        public static int Update(Genre genre, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblGenre row = dc.tblGenres.Where(p => p.Id == genre.Id).FirstOrDefault();

                    row.Genre = genre.Name;
                    row.GenreDescription = genre.Description;

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

        public static int Delete(int id, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblGenre row = dc.tblGenres.Where(p => p.Id == id).FirstOrDefault();

                    if (row != null)
                    {
                        dc.tblGenres.Remove(row);
                        results = dc.SaveChanges();

                        if (rollback) dbContextTransaction.Rollback();
                    }
                    else
                    {
                        throw new Exception("Row could not be found");
                    }
                }
                return results;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
