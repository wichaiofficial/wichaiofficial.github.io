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
    public class EventPostManager
    {
        public static List<EventPost> Load()
        {
            try
            {
                List<EventPost> rows = new List<EventPost>();

                using (ggEntities dc = new ggEntities())
                {
                    var EventPosts = (from p in dc.tblEventPosts
                                              orderby p.Id
                                              select new
                                              {
                                                  p.Id,
                                                  p.Content,
                                                  p.Created,
                                                  p.EventThreadId,
                                                  p.CustomerId,
                                                  p.ImagePath
                                              }).ToList();

                    EventPosts.ForEach(p => rows.Add(new EventPost
                    {
                        Id = p.Id,
                        Content = p.Content,
                        Created = p.Created,
                        EventThreadId = p.EventThreadId,
                        CustomerId = p.CustomerId,
                        ImagePath = p.ImagePath
                    }));
                }
                return rows;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static EventPost LoadById(int id)
        {
            try
            {
                using (ggEntities dc = new ggEntities())
                {
                    tblEventPost row = dc.tblEventPosts.Where(p => p.Id == id).FirstOrDefault();

                    if (row != null)
                    {
                        return new EventPost
                        {
                            Id = row.Id,
                            Content = row.Content,
                            Created = row.Created,
                            EventThreadId = row.EventThreadId,
                            CustomerId = row.CustomerId,
                            ImagePath = row.ImagePath
                            
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

        public static int Insert(EventPost post, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblEventPost row = new tblEventPost();

                    row.Id = dc.tblEventPosts.Any() ? dc.tblEventPosts.Max(s => s.Id) + 1 : 1;
                    row.Content = post.Content;
                    row.Created = post.Created;
                    row.EventThreadId = post.EventThreadId;
                    row.CustomerId = post.CustomerId;
                    row.ImagePath = post.ImagePath;
                    post.Id = row.Id;

                    dc.tblEventPosts.Add(row);
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

        public static int Update(EventPost post, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblEventPost row = dc.tblEventPosts.Where(p => p.Id == post.Id).FirstOrDefault();

                    row.Content = post.Content;
                    row.Created = post.Created;
                    row.EventThreadId = post.EventThreadId;
                    row.CustomerId = post.CustomerId;
                    row.ImagePath = post.ImagePath;

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

                    tblEventPost row = dc.tblEventPosts.Where(p => p.Id == id).FirstOrDefault();

                    if (row != null)
                    {
                        dc.tblEventPosts.Remove(row);
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
