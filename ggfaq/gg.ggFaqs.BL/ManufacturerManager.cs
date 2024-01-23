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
    public static class ManufacturerManager
    {
        public static List<Manufacturer> Load()
        {
            try
            {
                List<Manufacturer> rows = new List<Manufacturer>();

                using (ggEntities dc = new ggEntities())
                {
                    var manufacturers = (from m in dc.tblManufacturers
                                 orderby m.Id
                                 select new
                                 {
                                     m.Id,
                                     m.Name,
                                     m.Address,
                                     m.City,
                                     m.State,
                                     m.Zip
                                 }).ToList();

                    manufacturers.ForEach(m => rows.Add(new Manufacturer
                    {
                        Id = m.Id,
                        Name = m.Name, 
                        Address = m.Address,
                        City = m.City, 
                        State = m.State, 
                        Zip= m.Zip
                    }));
                }
                return rows;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int Insert(Manufacturer manufacturer, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblManufacturer row = new tblManufacturer();

                    //Get the number above the current highest Id
                    row.Id = dc.tblManufacturers.Any() ? dc.tblManufacturers.Max(s => s.Id) + 1 : 1;

                    row.Name = manufacturer.Name;
                    row.Address = manufacturer.Address;
                    row.City = manufacturer.City;
                    row.State = manufacturer.State;
                    row.Zip = manufacturer.Zip;

                    //Backfill the Id
                    manufacturer.Id = row.Id;

                    //ADd the manufacturer to the table
                    dc.tblManufacturers.Add(row);
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

        public static int Update(Manufacturer manufacturer, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblManufacturer row = dc.tblManufacturers.Where(s => s.Id == manufacturer.Id).FirstOrDefault();

                    if (row != null)
                    {
                        row.Name = manufacturer.Name;
                        row.Address = manufacturer.Address;
                        row.City = manufacturer.City;
                        row.State = manufacturer.State;
                        row.Zip = manufacturer.Zip;

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

                    tblManufacturer row = dc.tblManufacturers.Where(s => s.Id == id).FirstOrDefault();

                    if (row != null)
                    {
                        dc.tblManufacturers.Remove(row);
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

        public static Manufacturer LoadById(int id)
        {
            try
            {
                using (ggEntities dc = new ggEntities())
                {
                    tblManufacturer row = dc.tblManufacturers.FirstOrDefault(s => s.Id == id);

                    if (row != null)
                    {
                        return new Manufacturer
                        {
                            Id = row.Id,
                            Name = row.Name,
                            Address = row.Address,
                            City = row.City,
                            State = row.State,
                            Zip = row.Zip
                        };
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
