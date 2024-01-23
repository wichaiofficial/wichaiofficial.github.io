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
    public static class RatingManager
    {
        public static List<Rating> Load()
        {
            try
            {
                List<Rating> rows = new List<Rating>();

                using (ggEntities dc = new ggEntities())
                {
                    var ratings = (from p in dc.tblRatings
                                 orderby p.Id
                                   select new
                                   {
                                       p.Id,
                                       p.Rating,
                                       p.RatingDescription
                                   }).ToList();

                    ratings.ForEach(p => rows.Add(new Rating
                    {
                        Id = p.Id,
                        Name = p.Rating,
                        Description = p.RatingDescription
                    }));
                }
                return rows;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static Rating LoadById(int id)
        {
            try
            {
                using (ggEntities dc = new ggEntities())
                {
                    tblRating row = dc.tblRatings.Where(p => p.Id == id).FirstOrDefault();

                    if (row != null)
                    {
                        return new Rating
                        {
                            Id = row.Id,
                            Name = row.Rating,
                            Description = row.RatingDescription
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

        public static int Insert(Rating rating, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblRating row = new tblRating();

                    row.Id = dc.tblRatings.Any() ? dc.tblRatings.Max(s => s.Id) + 1 : 1;
                    row.Rating = rating.Name;
                    row.RatingDescription = rating.Description;

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

        public static int Update(Rating rating, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblRating row = dc.tblRatings.Where(p => p.Id == rating.Id).FirstOrDefault();

                    row.Rating = rating.Name;
                    row.RatingDescription = rating.Description;

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

                    tblRating row = dc.tblRatings.Where(p => p.Id == id).FirstOrDefault();

                    if (row != null)
                    {
                        dc.tblRatings.Remove(row);
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
