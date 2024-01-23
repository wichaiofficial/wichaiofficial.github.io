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
    public static class SystemManager
    {
        public static List<BL.Models.System> Load()
        {
            try
            {
                List<BL.Models.System> rows = new List<BL.Models.System>();

                using (ggEntities dc = new ggEntities())
                {
                    var systems = (from p in dc.tblSystems
                                   orderby p.Id
                                   select new
                                   {
                                       p.Id,
                                       p.Name,
                                       p.ManufacturerId,
                                       p.Release
                                   }).ToList();

                    systems.ForEach(p => rows.Add(new BL.Models.System
                    {
                        Id = p.Id,
                        Name = p.Name,
                        ManufacturerId = p.ManufacturerId,
                        ReleaseDate = p.Release
                    }));
                }
                return rows;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static BL.Models.System LoadById(int id)
        {
            try
            {
                using (ggEntities dc = new ggEntities())
                {
                    tblSystem row = dc.tblSystems.Where(p => p.Id == id).FirstOrDefault();

                    if (row != null)
                    {
                        return new BL.Models.System
                        {
                            Id = row.Id,
                            Name = row.Name,
                            ManufacturerId = row.ManufacturerId,
                            ReleaseDate = row.Release
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

        public static int Insert(BL.Models.System system, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblSystem row = new tblSystem();

                    row.Id = dc.tblSystems.Any() ? dc.tblSystems.Max(s => s.Id) + 1 : 1;
                    row.Name = system.Name;
                    row.ManufacturerId = system.ManufacturerId;
                    row.Release = system.ReleaseDate;

                    dc.tblSystems.Add(row);
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

        public static int Update(BL.Models.System system, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblSystem row = dc.tblSystems.Where(p => p.Id == system.Id).FirstOrDefault();

                    row.Name = system.Name;
                    row.ManufacturerId = system.ManufacturerId;

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

                    tblSystem row = dc.tblSystems.Where(p => p.Id == id).FirstOrDefault();

                    if (row != null)
                    {
                        dc.tblSystems.Remove(row);
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
