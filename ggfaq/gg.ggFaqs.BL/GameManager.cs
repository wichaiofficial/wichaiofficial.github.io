using gg.ggFaqs.BL.Models;
using gg.ggFaqs.PL;
using Microsoft.EntityFrameworkCore.Storage;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gg.ggFaqs.BL
{
    public static class GameManager
    {
        public static List<Game> Load()
        {
            try
            {
                List<Game> rows = new List<Game>();

                using (ggEntities dc = new ggEntities())
                {
                    var games = (from g in dc.tblGames
                                 orderby g.Id
                                 select new
                                 {
                                     g.Id,
                                     g.Title,
                                     g.Release,
                                     g.SystemId,
                                     g.RatingId,
                                     g.GenreId,
                                     g.GameDeveloperId,
                                     g.ImagePath,
                                     g.GameDeveloper,
                                     g.Genre
                                 }).ToList();

                    games.ForEach(g => rows.Add(new Game
                    {
                        Id = g.Id,
                        Title = g.Title,
                        ReleaseDate = g.Release,
                        SystemId = g.SystemId,
                        RatingId = g.RatingId,
                        GenreId = g.GenreId,
                        PublisherId = g.GameDeveloperId,
                        ImagePath = "https://ggfaqstorage.blob.core.windows.net/ggfaqsmainstorage/" + g.ImagePath,
                        Publisher = new Manufacturer
                        {
                            Name = g.GameDeveloper.DeveloperName
                        },
                        Genre = new Genre
                        {
                            Name = g.Genre.Genre
                        }

                    }));
                }
                return rows;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int Insert(Game game, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblGame row = new tblGame();

                    //Get the number above the current highest Id
                    row.Id = dc.tblGames.Any() ? dc.tblGames.Max(s => s.Id) + 1 : 1;

                    row.Title = game.Title;
                    row.Release = game.ReleaseDate;
                    row.SystemId = game.SystemId;
                    row.RatingId = game.RatingId;
                    row.GenreId = game.GenreId;
                    row.GameDeveloperId = game.PublisherId;
                    row.ImagePath= game.ImagePath;

                    //Backfill the Id
                    game.Id = row.Id;

                    //ADd the game to the table
                    dc.tblGames.Add(row);
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

        public static int Update(Game game, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblGame row = dc.tblGames.Where(s => s.Id == game.Id).FirstOrDefault();

                    if (row != null)
                    {
                        row.Title = game.Title;
                        row.Release = game.ReleaseDate;
                        row.SystemId = game.SystemId;
                        row.RatingId = game.RatingId;
                        row.GenreId = game.GenreId;
                        row.GameDeveloperId = game.PublisherId;
                        row.ImagePath = game.ImagePath;


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

                    tblGame row = dc.tblGames.Where(s => s.Id == id).FirstOrDefault();

                    if (row != null)
                    {
                        dc.tblGames.Remove(row);
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

        public static Game LoadById(int id)
        {
            try
            {
                using (ggEntities dc = new ggEntities())
                {
                    tblGame row = dc.tblGames.FirstOrDefault(s => s.Id == id);

                    if (row != null)
                    {
                        Game g = new Game()
                        {
                            Id = row.Id,
                            Title = row.Title,
                            ReleaseDate = row.Release,
                            SystemId = row.SystemId,
                            RatingId = row.RatingId,
                            GenreId = row.GenreId,
                            PublisherId = row.GameDeveloperId,
                            ImagePath = "https://ggfaqstorage.blob.core.windows.net/ggfaqsmainstorage/" + row.ImagePath,
                            Publisher = new Manufacturer
                            {
                                Name = row.GameDeveloper.DeveloperName
                            },
                            Genre = new Genre
                            {
                                Name = row.Genre.Genre
                            }
                        };

                        //Load SystemId?
                        //Load RatingId?
                        //Load GenreId?
                        //Load PublisherId?

                        return g;

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

        public static List<Game> LoadByGenreId(int genreId)
        {
            try
            {
                List<Game> rows = new List<Game>();

                using (ggEntities dc = new ggEntities())
                {
                    var games = (from g in dc.tblGames
                                 orderby g.Id
                                 where g.GenreId == genreId
                                 select new
                                 {
                                     g.Id,
                                     g.Title,
                                     g.Release,
                                     g.SystemId,
                                     g.RatingId,
                                     g.GenreId,
                                     g.GameDeveloperId,
                                     g.ImagePath
                                 }).ToList();

                    games.ForEach(g => rows.Add(new Game
                    {
                        Id = g.Id,
                        Title = g.Title,
                        ReleaseDate = g.Release,
                        SystemId = g.SystemId,
                        RatingId = g.RatingId,
                        GenreId = g.GenreId,
                        PublisherId = g.GameDeveloperId,
                        ImagePath = "https://ggfaqstorage.blob.core.windows.net/ggfaqsmainstorage/" + g.ImagePath
                    }));
                }
                return rows;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<Game> LoadByRatingId(int ratingId)
        {
            try
            {
                List<Game> rows = new List<Game>();

                using (ggEntities dc = new ggEntities())
                {
                    var games = (from g in dc.tblGames
                                 orderby g.Id
                                 where g.RatingId == ratingId
                                 select new
                                 {
                                     g.Id,
                                     g.Title,
                                     g.Release,
                                     g.SystemId,
                                     g.RatingId,
                                     g.GenreId,
                                     g.GameDeveloperId,
                                     g.ImagePath
                                 }).ToList();

                    games.ForEach(g => rows.Add(new Game
                    {
                        Id = g.Id,
                        Title = g.Title,
                        ReleaseDate = g.Release,
                        SystemId = g.SystemId,
                        RatingId = g.RatingId,
                        GenreId = g.GenreId,
                        PublisherId = g.GameDeveloperId,
                        ImagePath = "https://ggfaqstorage.blob.core.windows.net/ggfaqsmainstorage/" + g.ImagePath
                    }));
                }
                return rows;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public static List<Game> LoadByTitle(string gameTitle)
        {
            try
            {
                List<Game> rows = new List<Game>();

                using (ggEntities dc = new ggEntities())
                {
                    var games = (from g in dc.tblGames
                                 orderby g.Id
                                 where g.Title == gameTitle
                                 select new
                                 {
                                     g.Id,
                                     g.Title,
                                     g.Release,
                                     g.SystemId,
                                     g.RatingId,
                                     g.GenreId,
                                     g.GameDeveloperId,
                                     g.ImagePath,
                                     g.GameDeveloper,
                                     g.Genre
                                 }).ToList();

                    games.ForEach(g => rows.Add(new Game
                    {
                        Id = g.Id,
                        Title = g.Title,
                        ReleaseDate = g.Release,
                        SystemId = g.SystemId,
                        RatingId = g.RatingId,
                        GenreId = g.GenreId,
                        PublisherId = g.GameDeveloperId,
                        ImagePath = "https://ggfaqstorage.blob.core.windows.net/ggfaqsmainstorage/" + g.ImagePath,
                        Publisher = new Manufacturer
                        {
                            Name = g.GameDeveloper.DeveloperName
                        },
                        Genre = new Genre
                        {
                            Name = g.Genre.Genre
                        }
                    }));
                }
                return rows;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static Game LoadByThreadId(int id)
        {
            try
            {
                using (ggEntities dc = new ggEntities())
                {
                    tblGame row = dc.tblGames.FirstOrDefault(s => s.Id == id);

                    if (row != null)
                    {
                        Game g = new Game()
                        {
                            Id = row.Id,
                            Title = row.Title,
                            ReleaseDate = row.Release,
                            SystemId = row.SystemId,
                            RatingId = row.RatingId,
                            GenreId = row.GenreId,
                            PublisherId = row.GameDescriptionId,
                            ImagePath = "https://ggfaqstorage.blob.core.windows.net/ggfaqsmainstorage/" + row.ImagePath
                        };
                        return g;
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

        public static async Task<string> GetPromptFromChatGPT(string newPrompt)
        {
            string apiKey = "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";
            HttpClient Http = new HttpClient();
            Http.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");


            // JSON content for the API call
            var jsonContent = new
            {
                prompt = newPrompt,
                model = "text-davinci-003",
                max_tokens = 1000
            };

            // Make the API call
            var responseContent = await Http.PostAsync("https://api.openai.com/v1/completions", new StringContent(JsonConvert.SerializeObject(jsonContent), Encoding.UTF8, "application/json"));

            // Read the response as a string
            var resContext = await responseContent.Content.ReadAsStringAsync();

            // Deserialize the response into a dynamic object
            var data = JsonConvert.DeserializeObject<dynamic>(resContext);
            return data.choices[0].text;
        }

    }
}
