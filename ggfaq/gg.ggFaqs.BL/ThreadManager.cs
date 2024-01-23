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
    public static class ThreadManager
    {
        public static List<BL.Models.Thread> Load()
        {
            try
            {
                List<BL.Models.Thread> rows = new List<BL.Models.Thread>();

                using (ggEntities dc = new ggEntities())
                {
                    var threads = (from p in dc.tblThreads
                                  orderby p.Id
                                  select new
                                  {
                                      p.Id,
                                      p.Title,
                                      p.Subject,
                                      p.Created,
                                      p.CustomerId,
                                      p.GameId
                                  }).ToList();

                    threads.ForEach(p => rows.Add(new BL.Models.Thread
                    {
                        Id = p.Id,
                        Title = p.Title,
                        Subject = p.Subject,
                        Created = p.Created,
                        CustomerId = p.CustomerId,
                        GameId = p.GameId
                    }));
                }
                return rows;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static BL.Models.Thread LoadById(int id)
        {
            try
            {
                using (ggEntities dc = new ggEntities())
                {
                    tblThread row = dc.tblThreads.Where(p => p.Id == id).FirstOrDefault();

                    if (row != null)
                    {
                        return new BL.Models.Thread
                        {
                            Id = row.Id,
                            Title = row.Title,
                            Subject = row.Subject,
                            Created = row.Created,
                            CustomerId = row.CustomerId,
                            GameId = row.GameId
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

        public static List<BL.Models.Thread> LoadByGameId(int gameId)
        {
            try
            {
                List<BL.Models.Thread> threads = new List<BL.Models.Thread>();
                using (ggEntities dc = new ggEntities())
                {
                    List<tblThread> rows = dc.tblThreads.Where(g =>  g.GameId == gameId).ToList();

                    if (rows != null)
                    {
                        foreach(tblThread row in rows)
                        {
                            BL.Models.Thread thread = new BL.Models.Thread();

                            thread.Id = row.Id;
                            thread.Title = row.Title;
                            thread.Subject = row.Subject;
                            thread.Created = row.Created;
                            thread.CustomerId = row.CustomerId;
                            thread.GameId = row.GameId;
                            threads.Add(thread);
                        }
                        return threads;
                    }
                    else
                    {
                        throw new Exception("Rows not found");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<BL.Models.Thread> LoadByCustomerId(int customerId)
        {
            try
            {
                List<BL.Models.Thread> threads = new List<BL.Models.Thread>();
                using (ggEntities dc = new ggEntities())
                {
                    List<tblThread> rows = dc.tblThreads.Where(g => g.CustomerId == customerId).ToList();

                    if (rows != null)
                    {
                        foreach (tblThread row in rows)
                        {
                            BL.Models.Thread thread = new BL.Models.Thread();

                            thread.Id = row.Id;
                            thread.Title = row.Title;
                            thread.Subject = row.Subject;
                            thread.Created = row.Created;
                            thread.CustomerId = row.CustomerId;
                            thread.GameId = row.GameId;
                            threads.Add(thread);
                        }
                        return threads;
                    }
                    else
                    {
                        throw new Exception("Rows not found");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static BL.Models.Thread Insert(BL.Models.Thread thread, bool rollback = false)
        {
            try
            {
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblThread row = new tblThread();

                    row.Id = dc.tblThreads.Any() ? dc.tblThreads.Max(s => s.Id) + 1 : 1;
                    row.Title = thread.Title;
                    row.Subject = thread.Subject;
                    row.Created = thread.Created;
                    row.CustomerId = thread.CustomerId;
                    row.GameId = thread.GameId;
                    thread.Id = row.Id;

                    dc.tblThreads.Add(row);
                    dc.SaveChanges();

                    if (rollback) dbContextTransaction.Rollback();
                }
                return thread;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int Update(BL.Models.Thread thread, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblThread row = dc.tblThreads.Where(p => p.Id == thread.Id).FirstOrDefault();

                    row.Title = thread.Title;
                    row.Subject = thread.Subject;
                    row.Created = thread.Created;
                    row.CustomerId = thread.CustomerId;
                    row.GameId = thread.GameId;


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

                    tblThread row = dc.tblThreads.Where(p => p.Id == id).FirstOrDefault();

                    if (row != null)
                    {
                        dc.tblThreads.Remove(row);
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

        public static async Task<bool> ModerateThread(string newThread)
        {
            string apiKey = "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";
            HttpClient Http = new HttpClient();
            Http.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

            string promptPreFix = "You are a moderator on a video game forum, you will be given a post that a user submitted. Your job is to deciede if the post is within the rules and is allowed to be posted on the forum.";
            string rules = "Our rules are as follows: 1. No unnessary vulgar language, swearing is allowed but within reason. 2. No sexual language or remarks are allowed. 3. Calling other users names, or being rude in genreal is not allowed. ";
            string answerRequirements = "If you think the post violates the rules of the forum, please respond with just 'no', if the post does not violate the rules, please respond with just 'yes'. Make sure your response back is just 'yes' or 'no' only. Please only judge your answer based on the post which is starting now: ";

            // JSON content for the API call
            var jsonContent = new
            {
                prompt = promptPreFix + answerRequirements + rules + newThread,
                model = "text-davinci-003",
                max_tokens = 1000
            };

            // Make the API call
            var responseContent = await Http.PostAsync("https://api.openai.com/v1/completions", new StringContent(JsonConvert.SerializeObject(jsonContent), Encoding.UTF8, "application/json"));

            // Read the response as a string
            var resContext = await responseContent.Content.ReadAsStringAsync();

            // Deserialize the response into a dynamic object
            var data = JsonConvert.DeserializeObject<dynamic>(resContext);
            string verdict = data.choices[0].text;
            verdict = verdict.ToLower();
            if (verdict.Contains("yes"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
