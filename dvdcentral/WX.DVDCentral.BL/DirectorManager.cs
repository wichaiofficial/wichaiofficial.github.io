using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.DVDCentral.PL;
using WX.DVDCentral.BL.Models;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Update;

namespace WX.DVDCentral.BL
{
    public static class DirectorManager
    {
        private const string Message = "Row does not exist";

        public static int Insert(Director director, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblDirector row = new tblDirector();

                    // The Ternary Operator
                    row.Id = dc.tblDirectors.Any() ? dc.tblDirectors.Max(s => s.Id) + 1 : 1;
                    row.FirstName = director.FirstName;
                    row.LastName = director.LastName;

                    // Backfilling the ID
                    director.Id = row.Id;

                    dc.tblDirectors.Add(row);
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

        public static List<Director> Load()
        {
            // SELECT * FROM TBLGENRE
            try
            {
                List<Director> rows = new List<Director>();

                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    dc.tblDirectors
                        .ToList()
                        .ForEach(s => rows.Add(new Director
                        {
                            Id = s.Id,
                            FirstName = s.FirstName,
                            LastName = s.LastName,
                        }));
                    return rows;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static Director LoadbyId(int id)
        {
            try
            {
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    tblDirector row = dc.tblDirectors.FirstOrDefault(s => s.Id == id);

                    if (row != null)
                    {
                        return new Director
                        {
                            Id = row.Id,
                            FirstName = row.FirstName,
                            LastName = row.LastName,
                        };
                    }
                    else
                    {
                        throw new Exception(Message);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static int Update(Director director, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblDirector row = dc.tblDirectors.Where(s => s.Id == director.Id).FirstOrDefault();

                    if (row != null)
                    {
                        row.FirstName = director.FirstName;
                        row.LastName = director.LastName;
                        results = dc.SaveChanges();

                        if (rollback) dbContextTransaction.Rollback();
                    }
                    else
                    {
                        throw new Exception(Message);
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
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblDirector row = dc.tblDirectors.Where(s => s.Id == id).FirstOrDefault();

                    if (row != null)
                    {
                        dc.tblDirectors.Remove(row);
                        results = dc.SaveChanges();

                        if (rollback) dbContextTransaction.Rollback();
                    }
                    else
                    {
                        throw new Exception(Message);
                    }
                }
                return results;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
