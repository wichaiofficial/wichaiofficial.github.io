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
    public class EventThreadManager
    {
        public static List<EventThread> Load()
        {
            try
            {
                List<EventThread> rows = new List<EventThread>();

                using (ggEntities dc = new ggEntities())
                {
                    var EventThreads = (from t in dc.tblEventThreads
                                      orderby t.Id
                                      select new
                                      {
                                          t.Id,
                                          t.EventName,
                                          t.EventDate,
                                          t.CustomerId,
                                          t.Online,
                                          t.Zip,
                                          t.Active
                                      }).ToList();

                    EventThreads.ForEach(t => rows.Add(new EventThread
                    {
                        Id = t.Id,
                        EventName = t.EventName,
                        EventDate = t.EventDate,
                        CustomerId = t.CustomerId,
                        Online = t.Online,
                        Zip = t.Zip,
                        Active = t.Active
                    }));
                }
                return rows;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static EventThread LoadById(int id)
        {
            try
            {
                using (ggEntities dc = new ggEntities())
                {
                    tblEventThread row = dc.tblEventThreads.Where(t => t.Id == id).FirstOrDefault();

                    if (row != null)
                    {
                        return new EventThread
                        {
                            Id = row.Id,
                            EventName = row.EventName,
                            EventDate = row.EventDate,
                            CustomerId = row.CustomerId,
                            Online = row.Online,
                            Zip = row.Zip,
                            Active = row.Active

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

        public static int Insert(EventThread thread, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblEventThread row = new tblEventThread();

                    row.Id = dc.tblEventThreads.Any() ? dc.tblEventThreads.Max(s => s.Id) + 1 : 1;
                    row.EventName = thread.EventName;
                    row.EventDate = thread.EventDate;
                    row.CustomerId = thread.CustomerId;
                    row.Online = thread.Online;
                    row.Zip = thread.Zip;
                    row.Active = thread.Active;
                    thread.Id = row.Id;

                    dc.tblEventThreads.Add(row);
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

        public static int Update(EventThread thread, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblEventThread row = dc.tblEventThreads.Where(t => t.Id == thread.Id).FirstOrDefault();

                    row.EventName = thread.EventName;
                    row.EventDate = thread.EventDate;
                    row.CustomerId = thread.CustomerId;
                    row.Online = thread.Online;
                    row.Zip = thread.Zip;
                    row.Active = thread.Active;


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

                    tblEventThread row = dc.tblEventThreads.Where(t => t.Id == id).FirstOrDefault();

                    if (row != null)
                    {
                        dc.tblEventThreads.Remove(row);
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
