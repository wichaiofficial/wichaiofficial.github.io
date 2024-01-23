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
    public static class CustomerManager
    {
        public static List<Customer> Load()
        {
            try
            {
                List<Customer> rows = new List<Customer>();

                using (ggEntities dc = new ggEntities())
                {
                    var customers = (from c in dc.tblCustomers
                                     orderby c.Id
                                     select new
                                     {
                                         c.Id,
                                         c.FirstName,
                                         c.LastName,
                                         c.UserName,
                                         c.Password, 
                                         c.Address,
                                         c.City,
                                         c.State,
                                         c.Zip,
                                         c.Phone,
                                         c.Membership,
                                         c.DisplayName,
                                         c.profileImage,
                                         c.AboutMe,
                                         c.SocialSites
                                     }).ToList();



                    customers.ForEach(c => rows.Add(new Customer
                    {
                        Id = c.Id,
                        FirstName = c.FirstName,
                        LastName = c.LastName,
                        Username = c.UserName,
                        Password = c.Password,
                        Address = c.Address,
                        City = c.City,
                        State = c.State,
                        ZipCode = c.Zip,
                        Phone = c.Phone,
                        DisplayName = c.DisplayName,
                        ProfileImage = c.profileImage,
                        AboutMe = c.AboutMe,
                        SocialSites = c.SocialSites
                    }));
                }
                return rows;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool Login(string username, string password)
        {
            try
            {
                using (ggEntities dc = new ggEntities())
                {
                    tblCustomer row = dc.tblCustomers.FirstOrDefault(c => c.UserName == username);

                    if (row != null)
                    {
                        if (row.Password == password)
                        {
                            return true;
                        }
                        else
                        {
                            throw new Exception("Incorrect password");
                        }
                    }
                    else
                    {
                        throw new Exception("User could not be found");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int Insert(Customer customer, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblCustomer row = new tblCustomer();
                    tblLibrary librow = new tblLibrary();

                    //Get the number above the current highest Id
                    row.Id = dc.tblCustomers.Any() ? dc.tblCustomers.Max(s => s.Id) + 1 : 1;

                    row.FirstName = customer.FirstName;
                    row.LastName = customer.LastName;
                    row.UserName = customer.Username;
                    row.Password = customer.Password;
                    row.Address = customer.Address;
                    row.City = customer.City;
                    row.State = customer.State;
                    row.Zip = customer.ZipCode;
                    row.Phone = customer.Phone;
                    row.DisplayName = customer.DisplayName;
                    row.profileImage = customer.ProfileImage;
                    row.AboutMe = customer.AboutMe;
                    row.SocialSites = customer.SocialSites;

                    //Backfill the Id
                    customer.Id = row.Id;

                    //ADd the customer to the table
                    dc.tblCustomers.Add(row);

                    //Create Library on Account Creation
                    //librow.Id = row.Id;
                    //librow.CustomerId = row.Id;

                    //dc.tblLibraries.Add(librow);


                    results = dc.SaveChanges();

                    //Create Library on Account Creation
                    librow.Id = row.Id;
                    librow.CustomerId = row.Id;

                    dc.tblLibraries.Add(librow);

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

        public static int Update(Customer customer, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (ggEntities dc = new ggEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblCustomer row = dc.tblCustomers.Where(s => s.Id == customer.Id).FirstOrDefault();

                    if (row != null)
                    {
                        row.FirstName = customer.FirstName;
                        row.LastName = customer.LastName;
                        row.UserName = customer.Username;
                        row.Password = customer.Password;
                        row.Address = customer.Address;
                        row.City = customer.City;
                        row.State = customer.State;
                        row.Zip = customer.ZipCode;
                        row.Phone = customer.Phone;
                        row.DisplayName = customer.DisplayName;
                        row.profileImage = customer.ProfileImage;
                        row.AboutMe = customer.AboutMe;
                        row.SocialSites = customer.SocialSites;

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

                    tblCustomer row = dc.tblCustomers.Where(s => s.Id == id).FirstOrDefault();

                    if (row != null)
                    {
                        dc.tblCustomers.Remove(row);
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

        public static Customer LoadById(int id)
        {
            try
            {
                using (ggEntities dc = new ggEntities())
                {
                    tblCustomer row = dc.tblCustomers.FirstOrDefault(s => s.Id == id);

                    if (row != null)
                    {
                        Customer c = new Customer()
                        {
                            Id = row.Id,
                            FirstName = row.FirstName,
                            LastName = row.LastName,
                            Username = row.UserName,
                            Password = row.Password,
                            Address = row.Address,
                            City = row.City,
                            State = row.State,
                            ZipCode = row.Zip,
                            Phone = row.Phone,
                            DisplayName = row.DisplayName,
                            ProfileImage = row.profileImage,
                            AboutMe = row.AboutMe,
                            SocialSites = row.SocialSites
                        };
                        return c;
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

        public static Customer LoadByUsername(string username)
        {
            try
            {
                using (ggEntities dc = new ggEntities())
                {
                    tblCustomer row = dc.tblCustomers.FirstOrDefault(s => s.UserName == username);

                    if (row != null)
                    {
                        Customer c = new Customer()
                        {
                            Id = row.Id,
                            FirstName = row.FirstName,
                            LastName = row.LastName,
                            Username = row.UserName,
                            Password = row.Password,
                            Address = row.Address,
                            City = row.City,
                            State = row.State,
                            ZipCode = row.Zip,
                            Phone = row.Phone,
                            DisplayName = row.DisplayName,
                            ProfileImage = row.profileImage,
                            AboutMe = row.AboutMe,
                            SocialSites = row.SocialSites
                        };
                        return c;
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

        public static Customer LoadByThreadId(int id)
        {
            try
            {
                using (ggEntities dc = new ggEntities())
                {
                    tblCustomer row = dc.tblCustomers.FirstOrDefault(s => s.Id == id);

                    if (row != null)
                    {
                        Customer c = new Customer()
                        {
                            Id = row.Id,
                            FirstName = row.FirstName,
                            LastName = row.LastName,
                            Username = row.UserName,
                            Password = row.Password,
                            Address = row.Address,
                            City = row.City,
                            State = row.State,
                            ZipCode = row.Zip,
                            Phone = row.Phone,
                            DisplayName = row.DisplayName,
                            ProfileImage = row.profileImage,
                            AboutMe = row.AboutMe,
                            SocialSites = row.SocialSites
                        };
                        return c;
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
