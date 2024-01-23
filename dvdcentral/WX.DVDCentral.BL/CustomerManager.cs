﻿using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.DVDCentral.PL;
using WX.DVDCentral.BL.Models;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Update;
using Newtonsoft.Json.Linq;

namespace WX.DVDCentral.BL
{
    public static class CustomerManager
    {
        private const string Message = "Row does not exist";

        public static int Insert(Customer customer, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblCustomer row = new tblCustomer();

                    // The Ternary Operator
                    row.Id = dc.tblCustomers.Any() ? dc.tblCustomers.Max(s => s.Id) + 1 : 1;

                    row.FirstName = customer.FirstName;
                    row.LastName = customer.LastName;
                    row.Address = customer.Address;
                    row.City = customer.City;
                    row.State = customer.State;
                    row.Zip = customer.Zip;
                    row.Phone = customer.Phone;
                    row.UserId = customer.UserId;

                    // Backfilling the ID
                    customer.Id = row.Id;

                    dc.tblCustomers.Add(row);
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

        public static List<Customer> Load()
        {
            // SELECT * FROM TBLCustomer
            try
            {
                List<Customer> rows = new List<Customer>();

                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    dc.tblCustomers
                        .ToList()
                        .ForEach(s => rows.Add(new Customer
                        {
                            Id = s.Id,
                            FirstName = s.FirstName,
                            LastName = s.LastName,
                            Address = s.Address,
                            City = s.City,
                            State = s.State,
                            Zip = s.Zip,
                            Phone = s.Phone,
                            UserId = s.UserId

                }));
                    return rows;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static Customer LoadbyId(int id)
        {
            try
            {
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    tblCustomer row = dc.tblCustomers.FirstOrDefault(s => s.Id == id);

                    if (row != null)
                    {
                        return new Customer
                        {
                            Id = row.Id,
                            FirstName = row.FirstName,
                            LastName = row.LastName,
                            Address = row.Address,
                            City = row.City,
                            State = row.State,
                            Zip = row.Zip,
                            Phone = row.Phone,
                            UserId =row.UserId

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

        public static int Update(Customer customer, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblCustomer row = dc.tblCustomers.Where(s => s.Id == customer.Id).FirstOrDefault();

                    if (row != null)
                    {
                        row.FirstName = customer.FirstName;
                        row.LastName = customer.LastName;
                        row.Address = customer.Address;
                        row.City = customer.City;
                        row.State = customer.State;
                        row.Zip = customer.Zip;
                        row.Phone = customer.Phone;
                        row.UserId = customer.UserId;

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

                    tblCustomer row = dc.tblCustomers.Where(s => s.Id == id).FirstOrDefault();

                    if (row != null)
                    {
                        dc.tblCustomers.Remove(row);
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
