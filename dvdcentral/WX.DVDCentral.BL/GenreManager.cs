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
using System.Security.Cryptography;

namespace WX.DVDCentral.BL
{
    public static class GenreManager
    {
		private const string Message = "Row does not exist";
        public static int Insert(Genre genre, bool rollback = false)
        {
			try
			{
				int results = 0;
				using (DVDCentralEntities dc = new DVDCentralEntities())
				{
					IDbContextTransaction dbContextTransaction = null;
					if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

					tblGenre row = new tblGenre();

					// The Ternary Operator
					row.Id = dc.tblGenres.Any() ? dc.tblGenres.Max(s=>s.Id)+1 : 1;
					row.Description = genre.Description;

					// Backfilling the ID
					genre.Id = row.Id;

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

		public static List<Genre> Load(int? movieId = null)
		{
			// SELECT * FROM TBLGENRE
			try
			{
				List<Genre> rows = new List<Genre>();

				using (DVDCentralEntities dc = new DVDCentralEntities())
				{
					(from g in dc.tblGenres
					 join mg in dc.tblMovieGenres on g.Id equals mg.GenreId
					 where mg.MovieId == movieId || movieId == null
					 select new
					 {
						 g.Id,
						 g.Description
					 })
					 .Distinct()
					 .ToList()
					 .ForEach(g => rows.Add(new Genre
					 {
						 Id = g.Id,
						 Description = g.Description,
					 }));
					return rows;
				}
			}
			catch (Exception)
			{

				throw;
			}
		}
        public static List<Genre> Load()
        {
            // SELECT * FROM TBLGENRE
            try
            {
                List<Genre> rows = new List<Genre>();

                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    (from g in dc.tblGenres
                     select new
                     {
                         g.Id,
                         g.Description
                     })
                     .Distinct()
                     .ToList()
                     .ForEach(g => rows.Add(new Genre
                     {
                         Id = g.Id,
                         Description = g.Description,
                     }));
                    return rows;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static Genre LoadbyId(int id)
		{
			try
			{
				using (DVDCentralEntities dc = new DVDCentralEntities())
				{
					tblGenre row = dc.tblGenres.FirstOrDefault(s => s.Id == id);

					if(row != null)
					{
						return new Genre
						{
							Id = row.Id,
							Description = row.Description,
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

		public static int Update(Genre genre, bool rollback = false)
		{
			try
			{
				int results = 0;
				using (DVDCentralEntities dc = new DVDCentralEntities())
				{
					IDbContextTransaction dbContextTransaction = null;
					if(rollback) dbContextTransaction = dc.Database.BeginTransaction();

					tblGenre row = dc.tblGenres.Where(s=> s.Id == genre.Id).FirstOrDefault();

					if(row != null)
					{
						row.Description = genre.Description;
						results = dc.SaveChanges();

						if(rollback) dbContextTransaction.Rollback();
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
				using(DVDCentralEntities dc = new DVDCentralEntities())
				{
					IDbContextTransaction dbContextTransaction = null;
					if(rollback) dbContextTransaction = dc.Database.BeginTransaction();

					tblGenre row = dc.tblGenres.Where(s => s.Id == id).FirstOrDefault();

					if(row != null)
					{
						dc.tblGenres.Remove(row);
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
    }
}
