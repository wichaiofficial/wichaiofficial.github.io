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
    public static class CustomerAddedGameManager
    {
        public static List<CustomerAddedGame> Load()
        {
            try
            {
                List<CustomerAddedGame> rows = new List<CustomerAddedGame>();

                using (ggEntities dc = new ggEntities())
                {
                    var CustomerAddedGames = (from g in dc.tblCustomerAddedGames
                                  orderby g.AddGameId
                                  select new
                                  {
                                      g.AddGameId,
                                      g.CustomerId,
                                      g.GameTitle,
                                      g.System,
                                      g.GameDeveloper,
                                      g.Rating,
                                      g.Genre,
                                      g.InSystem
                                  }).ToList();

                    CustomerAddedGames.ForEach(g => rows.Add(new CustomerAddedGame
                    {
                        AddedGameId = g.AddGameId,
                        CustomerId = g.CustomerId,
                        GameTitle = g.GameTitle,
                        GameDeveloper = g.GameDeveloper,
                        System = g.System,
                        Rating = g.Rating,
                        Genre = g.Genre,
                        InSystem = g.InSystem
                    }));
                }
                return rows;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static CustomerAddedGame LoadById(int id)
        {
            try
            {
                using (ggEntities dc = new ggEntities())
                {
                    tblCustomerAddedGame row = dc.tblCustomerAddedGames.Where(g => g.AddGameId == id).FirstOrDefault();

                    if (row != null)
                    {
                        return new CustomerAddedGame
                        {
                            AddedGameId = row.AddGameId,
                            CustomerId = row.CustomerId,
                            GameTitle = row.GameTitle,
                            System = row.System,
                            GameDeveloper = row.GameDeveloper,
                            Rating = row.Rating,
                            Genre = row.Genre,
                            InSystem = row.InSystem
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

        public static int Insert(CustomerAddedGame game, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblCustomerAddedGame row = new tblCustomerAddedGame();

                    row.AddGameId = dc.tblCustomerAddedGames.Any() ? dc.tblCustomerAddedGames.Count() + 1 : 1;
                    row.GameTitle = game.GameTitle;
                    row.GameDeveloper = game.GameDeveloper;
                    row.CustomerId = game.CustomerId;
                    row.System = game.System;
                    row.Rating = game.Rating;
                    row.Genre = game.Genre;
                    row.InSystem = game.InSystem;

                    dc.tblCustomerAddedGames.Add(row);
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

        public static int Update(CustomerAddedGame game, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblCustomerAddedGame row = dc.tblCustomerAddedGames.Where(g => g.AddGameId == game.AddedGameId).FirstOrDefault();

                    row.GameTitle = game.GameTitle;
                    row.GameDeveloper = game.GameDeveloper;
                    row.CustomerId = game.CustomerId;
                    row.System = game.System;
                    row.Rating = game.Rating;
                    row.Genre = game.Genre;

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
                    if (rollback) dc.Database.BeginTransaction();

                    tblCustomerAddedGame row = dc.tblCustomerAddedGames.Where(g => g.AddGameId == id).FirstOrDefault();

                    if (row != null)
                    {
                        dc.tblCustomerAddedGames.Remove(row);
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
