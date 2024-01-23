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

namespace WX.DVDCentral.BL
{
    public static class MovieGenreManager
    {
        private const string Message = "Row does not exist";

        public static int Insert(int MovieId, int GenreId, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                   tblMovieGenre tblMovieGenre= new tblMovieGenre();
                    tblMovieGenre.MovieId = MovieId;
                    tblMovieGenre.GenreId = GenreId;
                    tblMovieGenre.Id = dc.tblMovieGenres.Any() ? dc.tblMovieGenres.Max(mg => mg.Id) + 1 : 1;

                    dc.tblMovieGenres.Add(tblMovieGenre);
                    dc.SaveChanges();

                }

                return results;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int Delete(int MovieId, int GenreId, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    tblMovieGenre? tblMovieGenre = dc.tblMovieGenres
                                                            .FirstOrDefault(mg => mg.MovieId == MovieId
                                                            && mg.GenreId == GenreId);
                    if (tblMovieGenre != null)
                    {
                        dc.tblMovieGenres.Remove(tblMovieGenre);
                        dc.SaveChanges();
                    }
                }
                return results;
 
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
