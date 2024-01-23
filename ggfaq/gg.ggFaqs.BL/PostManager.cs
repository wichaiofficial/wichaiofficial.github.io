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
    public static class PostManager
    {
        public static List<Post> Load()
        {
			try
			{
				List<Post> rows = new List<Post>();

				using (ggEntities dc = new ggEntities())
				{
					var posts = (from p in dc.tblPosts
								 orderby p.Id
                                 select new
                                 {
                                     p.Id,
                                     p.Content,
                                     p.Created,
									 p.ThreadId,
									 p.CustomerId,
									 p.ImagePath
                                 }).ToList();

                    posts.ForEach(p => rows.Add(new Post
					{
						Id = p.Id,
						Content = p.Content,
						Created = p.Created,
						ThreadID = p.ThreadId,
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

        public static Post LoadById(int id)
        {
            try
            {
                using (ggEntities dc = new ggEntities())
                {
                    tblPost row = dc.tblPosts.Where(p => p.Id == id).FirstOrDefault();

                    if (row != null)
                    {
						return new Post
						{
							Id = row.Id,
							Content = row.Content,
							Created = row.Created,
							ThreadID = row.ThreadId,
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

		public static List<Post> LoadByThreadId(int threadId)
		{
			try
			{
				List<Post> posts = new List<Post>();
                using (ggEntities dc = new ggEntities())
                {
                    List<tblPost> rows = dc.tblPosts.Where(p => p.ThreadId == threadId).ToList();

                    if (rows != null)
                    {
                        foreach(tblPost row in rows)
						{
							Post post = new Post();
							post.Id = row.Id;
							post.Content = row.Content;
							post.Created = row.Created;
							post.ThreadID = row.ThreadId;
							post.CustomerId = row.CustomerId;
							post.ImagePath = row.ImagePath;
							posts.Add(post);
						}
						return posts;
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

        public static List<Post> LoadByPlayerId(int customerId)
        {
            try
            {
                List<Post> posts = new List<Post>();
                using (ggEntities dc = new ggEntities())
                {
                    List<tblPost> rows = dc.tblPosts.Where(p => p.CustomerId == customerId).ToList();

                    if (rows != null)
                    {
                        foreach (tblPost row in rows)
                        {
                            Post post = new Post();
                            post.Id = row.Id;
                            post.Content = row.Content;
                            post.Created = row.Created;
                            post.ThreadID = row.ThreadId;
                            post.CustomerId = row.CustomerId;
                            post.ImagePath = row.ImagePath;
                            posts.Add(post);
                        }
                        return posts;
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

        public static int Insert(Post post, bool rollback = false)
		{
			try
			{
				int results = 0;
				using (ggEntities dc = new ggEntities())
				{
					IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblPost row = new tblPost();

					row.Id = dc.tblPosts.Any() ? dc.tblPosts.Max(s => s.Id) + 1 : 1;
					row.Content = post.Content;
					row.Created = post.Created;
					row.ThreadId = post.ThreadID;
					row.CustomerId = post.CustomerId;
					row.ImagePath = post.ImagePath;
					post.Id = row.Id;

					dc.tblPosts.Add(row);
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

		public static int Update(Post post, bool rollback = false)
		{
            try
            {
                int results = 0;
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblPost row = dc.tblPosts.Where(p => p.Id == post.Id).FirstOrDefault();

                    row.Content = post.Content;
                    row.Created = post.Created;
                    row.ThreadId = post.ThreadID;
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

                    tblPost row = dc.tblPosts.Where(p => p.Id == id).FirstOrDefault();

					if (row != null)
					{
						dc.tblPosts.Remove(row);
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
