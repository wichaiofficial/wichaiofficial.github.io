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
    public class GameUserRatingManager
    {
        public static List<GameUserRating> Load()
        {
            try
            {
                List<GameUserRating> rows = new List<GameUserRating>();

                using (ggEntities dc = new ggEntities())
                {
                    var GameUserRatings = (from r in dc.tblGameUserRatings
                                        orderby r.Id
                                        select new
                                        {
                                            r.Id,
                                            r.GameId,
                                            r.CustomerId,
                                            r.UserRating
                                        }).ToList();

                    GameUserRatings.ForEach(r => rows.Add(new GameUserRating
                    {
                        Id = r.Id,
                        GameId = r.GameId,
                        CustomerId = r.CustomerId,
                        UserRating = r.UserRating
                    }));
                }
                return rows;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static GameUserRating LoadById(int id)
        {
            try
            {
                using (ggEntities dc = new ggEntities())
                {
                    tblGameUserRating row = dc.tblGameUserRatings.Where(r => r.Id == id).FirstOrDefault();

                    if (row != null)
                    {
                        return new GameUserRating
                        {
                            Id = row.Id,
                            GameId = row.GameId,
                            CustomerId = row.CustomerId,
                            UserRating = row.UserRating

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

        public static int Insert(GameUserRating rating, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblGameUserRating row = new tblGameUserRating();

                    row.Id = dc.tblGameUserRatings.Any() ? dc.tblGameUserRatings.Max(s => s.Id) + 1 : 1;
                    row.GameId = rating.GameId;
                    row.CustomerId = rating.CustomerId;
                    row.UserRating = rating.UserRating;
                    rating.Id = row.Id;

                    dc.tblGameUserRatings.Add(row);
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

        public static int Update(GameUserRating rating, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblGameUserRating row = dc.tblGameUserRatings.Where(r => r.Id == rating.Id).FirstOrDefault();

                    row.GameId = rating.GameId;
                    row.CustomerId = rating.CustomerId;
                    row.UserRating = rating.UserRating;

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

                    tblGameUserRating row = dc.tblGameUserRatings.Where(r => r.Id == id).FirstOrDefault();

                    if (row != null)
                    {
                        dc.tblGameUserRatings.Remove(row);
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
