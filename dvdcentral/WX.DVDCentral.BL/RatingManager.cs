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
    public static class RatingManager
    {
        private const string Message = "Row does not exist";

        public static int Insert(Rating rating, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblRating row = new tblRating();

                    // The Ternary Operator
                    row.Id = dc.tblRatings.Any() ? dc.tblRatings.Max(s => s.Id) + 1 : 1;
                    row.Description = rating.Description;

                    // Backfilling the ID
                    rating.Id = row.Id;

                    dc.tblRatings.Add(row);
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

        public static List<Rating> Load()
        {
            // SELECT * FROM TBLGENRE
            try
            {
                List<Rating> rows = new List<Rating>();

                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    dc.tblRatings
                        .ToList()
                        .ForEach(s => rows.Add(new Rating
                        {
                            Id = s.Id,
                            Description = s.Description,
                        }));
                    return rows;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static Rating LoadbyId(int id)
        {
            try
            {
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    tblRating row = dc.tblRatings.FirstOrDefault(s => s.Id == id);

                    if (row != null)
                    {
                        return new Rating
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

        public static int Update(Rating rating, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblRating row = dc.tblRatings.Where(s => s.Id == rating.Id).FirstOrDefault();

                    if (row != null)
                    {
                        row.Description = rating.Description;
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

                    tblRating row = dc.tblRatings.Where(s => s.Id == id).FirstOrDefault();

                    if (row != null)
                    {
                        dc.tblRatings.Remove(row);
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
