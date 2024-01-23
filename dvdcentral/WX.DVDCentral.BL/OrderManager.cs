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
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Data;

namespace WX.DVDCentral.BL
{
    public static class OrderManager
    {
        private const string Message = "Row does not exist";

        public static int Insert(Order order, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblOrder row = new tblOrder();

                    // The Ternary Operator
                    row.Id = dc.tblOrders.Any() ? dc.tblOrders.Max(s => s.Id) + 1 : 1;
                    row.CustomerId = order.CustomerId;
                    row.OrderDate = order.OrderDate;
                    row.UserId = order.UserId;
                    row.ShipDate = order.ShipDate;

                    // Backfilling the ID
                    order.Id = row.Id;

                    dc.tblOrders.Add(row);
                    results = dc.SaveChanges();

                    //Deals with the order Items
                    foreach(OrderItem orderItem in order.Orderitem)
                    {
                        tblOrderItem newrow = new tblOrderItem();

                        newrow.Id = dc.tblOrderItems.Any() ? dc.tblOrderItems.Max(s => s.Id) + 1 : 1;
                        newrow.Cost = orderItem.Cost;
                        newrow.MovieId = orderItem.MovieId;
                        newrow.OrderId = order.Id;
                        newrow.Quantity = orderItem.Quantity;

                        dc.tblOrderItems.Add(newrow);
                        dc.SaveChanges();


                    }

                    if (rollback) dbContextTransaction.Rollback();
                }

                return results;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Order> Load(int? customerId = null)
        {
            try
            {
                List<Order> rows = new List<Order>();

                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    var order = (from o in dc.tblOrders
                                 join c in dc.tblCustomers on o.CustomerId equals c.Id
                                 join u in dc.tblUsers on c.UserId equals u.Id
                                 join oi in dc.tblOrderItems on o.Id equals oi.OrderId
                                 join m in dc.tblMovies on oi.MovieId equals m.Id
                                 where c.Id == customerId || customerId == null
                                 select new
                                 {
                                     Id = o.Id,
                                     CustomerName = c.FirstName + " " + c.LastName,
                                     CustomerId = c.Id,
                                     UserId = c.UserId,
                                     OrderDate = o.OrderDate,
                                     ShipDate = o.ShipDate,
                                     Username = u.UserName,
                                     UserFullName = u.FirstName + " " + u.LastName, 
                                 }).Distinct().ToList();

                    order.ForEach(o => rows.Add(new Models.Order
                    {
                        Id = o.Id,
                        CustomerId = o.CustomerId,
                        CustomerName = o.CustomerName,
                        OrderDate = o.OrderDate,
                        ShipDate = o.ShipDate,
                        UserId = o.UserId,
                        Username = o.Username,
                        UserFullName = o.UserFullName,

                        Orderitem = OrderItemManager.LoadByOrderId(o.Id)
                    })) ;
                }
                return rows;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static Order LoadbyId(int id)
        {
            try
            {
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    var row = (from o in dc.tblOrders
                               join c in dc.tblCustomers on o.CustomerId equals c.Id
                               join u in dc.tblUsers on c.UserId equals u.Id
                               join oi in dc.tblOrderItems on o.Id equals oi.OrderId
                               join m in dc.tblMovies on oi.MovieId equals m.Id
                               where o.Id == id
                               select new
                               {
                                   Id = o.Id,
                                   CustomerName = c.FirstName + " " + c.LastName,
                                   CustomerId = c.Id,
                                   UserId = c.UserId,
                                   OrderDate = o.OrderDate,
                                   ShipDate = o.ShipDate,
                                   Username = u.UserName,
                                   UserFullName = u.FirstName + " " + u.LastName,
                               }).FirstOrDefault();

                    if (row != null)
                    {
                        return new Order
                        {
                            Id = row.Id,
                            CustomerId = row.CustomerId,
                            CustomerName = row.CustomerName,
                            OrderDate = row.OrderDate,
                            ShipDate = row.ShipDate,
                            UserId = row.UserId,
                            Username = row.Username,
                            UserFullName = row.UserFullName,

                            Orderitem = OrderItemManager.LoadByOrderId(row.Id)
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

        public static int Update(Order order, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblOrder row = dc.tblOrders.Where(s => s.Id == order.Id).FirstOrDefault();

                    if (row != null)
                    {
                        row.CustomerId = order.CustomerId;
                        row.OrderDate = order.OrderDate;
                        row.UserId = order.UserId;
                        row.ShipDate = order.ShipDate;

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

                    tblOrder row = dc.tblOrders.Where(s => s.Id == id).FirstOrDefault();

                    if (row != null)
                    {
                        dc.tblOrders.Remove(row);
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

        public static List<Order> LoadByCustomerId(int customerId)
        {
            try
            {
                return Load(customerId);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
