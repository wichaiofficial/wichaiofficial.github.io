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
    public static class LibraryGameManager
    {

        public static List<LibraryGame> Load()
        {
            try
            {
                List<LibraryGame> rows = new List<LibraryGame>();

                using (ggEntities dc = new ggEntities())
                {
                    var libraryGames = (from lg in dc.tblLibraryGames
                                    orderby lg.Id
                                    select new
                                    {
                                        lg.Id,
                                        lg.GameId,
                                        lg.LibraryId,
                                        lg.DateAdded
                                    }).ToList();



                    libraryGames.ForEach(b => rows.Add(new LibraryGame
                    {
                        Id = b.Id,
                        GameId = b.GameId,
                        LibraryId = b.LibraryId,
                        DateAdded = b.DateAdded
                    }));
                }
                return rows;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int Insert(LibraryGame libraryGame, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblLibraryGame row = new tblLibraryGame();

                    //Get the number above the current highest Id
                    row.Id = dc.tblLibraryGames.Any() ? dc.tblLibraryGames.Max(s => s.Id) + 1 : 1;

                    row.GameId = libraryGame.GameId;
                    row.LibraryId = libraryGame.LibraryId;
                    row.DateAdded = DateTime.Now;

                    //Backfill the Id
                    libraryGame.Id = row.Id;

                    //ADd the libraryGame to the table
                    dc.tblLibraryGames.Add(row);
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

        public static int Update(LibraryGame libraryGame, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblLibraryGame row = dc.tblLibraryGames.Where(s => s.Id == libraryGame.Id).FirstOrDefault();

                    if (row != null)
                    {
                        row.GameId = libraryGame.GameId;
                        row.LibraryId = libraryGame.LibraryId;
                        row.DateAdded = libraryGame.DateAdded;

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
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblLibraryGame row = dc.tblLibraryGames.Where(s => s.Id == id).FirstOrDefault();

                    if (row != null)
                    {
                        dc.tblLibraryGames.Remove(row);
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
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static LibraryGame LoadById(int id)
        {
            try
            {
                using (ggEntities dc = new ggEntities())
                {
                    tblLibraryGame row = dc.tblLibraryGames.FirstOrDefault(s => s.Id == id);

                    if (row != null)
                    {
                        LibraryGame lg = new LibraryGame()
                        {
                            Id = row.Id,
                            GameId = row.Id,
                            LibraryId = row.LibraryId,
                            DateAdded = row.DateAdded
                        };

                        //Load Game?
                        //Load Library?

                        return lg;
                    }
                    else
                    {
                        throw new Exception("Row could not be found");
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<LibraryGame> LoadByLibraryId(int id)
        {
            try
            {
                List<LibraryGame> games = new List<LibraryGame>();
                using (ggEntities dc = new ggEntities())
                {
                    List<tblLibraryGame> rows = dc.tblLibraryGames.Where(s => s.LibraryId == id).ToList();

                    if (rows != null)
                    {
                        foreach (tblLibraryGame row in rows)
                        {
                            LibraryGame lg = new LibraryGame()
                            {
                                Id = row.Id,
                                GameId = row.Id,
                                LibraryId = row.LibraryId,
                                DateAdded = row.DateAdded
                            };
                            games.Add(lg);
                        }
                        return games;
                    }
                    else
                    {
                        throw new Exception("Row could not be found");
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<Game> GamesByLibraryId(int id)
        {
            try
            {
                List<Game> games = new List<Game>();
                using (ggEntities dc = new ggEntities())
                {
                    List<tblLibraryGame> rows = dc.tblLibraryGames.Where(s => s.LibraryId == id).ToList();

                    if (rows != null)
                    {
                        foreach (tblLibraryGame row in rows)
                        {
                            Game game = new Game
                            {
                                Id = row.Game.Id,
                                Title = row.Game.Title,
                                ReleaseDate = row.Game.Release,
                                SystemId = row.Game.SystemId,
                                RatingId = row.Game.RatingId,
                                GenreId = row.Game.GenreId,
                                PublisherId = row.Game.GameDeveloperId,
                                ImagePath = "https://ggfaqstorage.blob.core.windows.net/ggfaqsmainstorage/" + row.Game.ImagePath
                            };
                            games.Add(game);
                        }
                        return games;
                    }
                    else
                    {
                        throw new Exception("Row could not be found");
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
