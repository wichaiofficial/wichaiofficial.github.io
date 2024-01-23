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
    public static class LibraryManager
    {

        public static List<Library> Load()
        {
            try
            {
                List<Library> rows = new List<Library>();

                using (ggEntities dc = new ggEntities())
                {
                    var librarys = (from b in dc.tblLibraries
                                     orderby b.Id
                                     select new
                                     {
                                         b.Id,
                                         b.CustomerId
                                     }).ToList();



                    librarys.ForEach(b => rows.Add(new Library
                    {
                        Id = b.Id,
                        CustomerId = b.CustomerId
                    }));
                }
                return rows;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static Library LoadByCustomerId(int customerId)
        {
            try
            {
                using (ggEntities dc = new ggEntities())
                {
                    tblLibrary row = dc.tblLibraries.FirstOrDefault(s => s.CustomerId == customerId);

                    if (row != null)
                    {
                        Library b = new Library()
                        {
                            Id = row.Id,
                            CustomerId = row.CustomerId
                        };

                        return b;
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

        public static int Insert(Library library, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblLibrary row = new tblLibrary();

                    //Get the number above the current highest Id
                    row.Id = dc.tblLibraries.Any() ? dc.tblLibraries.Max(s => s.Id) + 1 : 1;

                    
                    row.CustomerId = library.CustomerId;

                    //Backfill the Id
                    library.Id = row.Id;

                    //ADd the library to the table
                    dc.tblLibraries.Add(row);
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

        public static int Update(Library library, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblLibrary row = dc.tblLibraries.Where(s => s.Id == library.Id).FirstOrDefault();

                    if (row != null)
                    {
                        
                        row.CustomerId = library.CustomerId;

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

                    tblLibrary row = dc.tblLibraries.Where(s => s.Id == id).FirstOrDefault();

                    if (row != null)
                    {
                        dc.tblLibraries.Remove(row);
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

        public static Library LoadById(int id)
        {
            try
            {
                using (ggEntities dc = new ggEntities())
                {
                    tblLibrary row = dc.tblLibraries.FirstOrDefault(s => s.Id == id);

                    if (row != null)
                    {
                        Library b = new Library()
                        {
                            Id = row.Id,
                            CustomerId = row.CustomerId
                        };

                        //Load Customer?
                        //Load LibraryGames?

                        return b;
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
