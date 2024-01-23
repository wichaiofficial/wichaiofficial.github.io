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
    public static class FormatManager
    {
        private const string Message = "Row does not exist";

        public static int Insert(Format format, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblFormat row = new tblFormat();

                    // The Ternary Operator
                    row.Id = dc.tblFormats.Any() ? dc.tblFormats.Max(s => s.Id) + 1 : 1;
                    row.Description = format.Description;

                    // Backfilling the ID
                    format.Id = row.Id;

                    dc.tblFormats.Add(row);
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

        public static List<Format> Load()
        {
            // SELECT * FROM TBLGENRE
            try
            {
                List<Format> rows = new List<Format>();

                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    dc.tblFormats
                        .ToList()
                        .ForEach(s => rows.Add(new Format
                        {
                            Id = s.Id,
                            Description = s.Description,
                        }));
                    return rows;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static Format LoadbyId(int id)
        {
            try
            {
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    tblFormat row = dc.tblFormats.FirstOrDefault(s => s.Id == id);

                    if (row != null)
                    {
                        return new Format
                        {
                            Id = row.Id,
                            Description = row.Description,
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

        public static int Update(Format format, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblFormat row = dc.tblFormats.Where(s => s.Id == format.Id).FirstOrDefault();

                    if (row != null)
                    {
                        row.Description = format.Description;
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

                    tblFormat row = dc.tblFormats.Where(s => s.Id == id).FirstOrDefault();

                    if (row != null)
                    {
                        dc.tblFormats.Remove(row);
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
