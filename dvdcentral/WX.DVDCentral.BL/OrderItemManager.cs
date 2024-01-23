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
using System.Data;

namespace WX.DVDCentral.BL
{
    public static class OrderItemManager
    {
        private const string Message = "Row does not exist";

        public static int Insert(OrderItem orderitem, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblOrderItem row = new tblOrderItem();

                    // The Ternary Operator
                    row.Id = dc.tblOrderItems.Any() ? dc.tblOrderItems.Max(s => s.Id) + 1 : 1;
                    row.OrderId = orderitem.OrderId;
                    row.MovieId = orderitem.MovieId;

                    // Backfilling the ID
                    orderitem.Id = row.Id;

                    dc.tblOrderItems.Add(row);
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

        public static List<OrderItem> Load(int? orderId = null)
        {
            // SELECT * FROM TBLGENRE
            try
            {
                List<OrderItem> rows = new List<OrderItem>();

                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    dc.tblOrderItems
                        .Where (o => o.Id == orderId || orderId == null)
                        .ToList()
                        .ForEach(s => rows.Add(new OrderItem
                        {
                            Id = s.Id,                       
                            OrderId = s.OrderId,
                            MovieId = s.MovieId,
                            Quantity= s.Quantity,
                            Cost = s.Cost,
                }));
                    return rows;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static OrderItem LoadbyId(int id)
        {
            try
            {
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    tblOrderItem row = dc.tblOrderItems.FirstOrDefault(s => s.Id == id);

                    if (row != null)
                    {
                        return new OrderItem
                        {
                            Id = row.Id,
                            OrderId = row.OrderId,
                            MovieId = row.MovieId
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

        public static int Update(OrderItem orderitem, bool rollback = false)
        {
            try
            {
                int results = 0;
                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    IDbContextTransaction dbContextTransaction = null;
                    if (rollback) dbContextTransaction = dc.Database.BeginTransaction();

                    tblOrderItem row = dc.tblOrderItems.Where(s => s.Id == orderitem.Id).FirstOrDefault();

                    if (row != null)
                    {
                        row.OrderId = orderitem.OrderId;
                        row.MovieId = orderitem.MovieId;
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

                    tblOrderItem row = dc.tblOrderItems.Where(s => s.Id == id).FirstOrDefault();

                    if (row != null)
                    {
                        dc.tblOrderItems.Remove(row);
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

        public static List<OrderItem> LoadByOrderId(int? orderid = null)
        {
            try
            {
                List<OrderItem> rows = new List<OrderItem>();

                using (DVDCentralEntities dc = new DVDCentralEntities())
                {
                    var orderitems = (from oi in dc.tblOrderItems
                                      join o in dc.tblOrders on oi.OrderId equals o.Id
                                      join c in dc.tblCustomers on o.CustomerId equals c.Id
                                      join m in dc.tblMovies on oi.MovieId equals m.Id
                                      where oi.OrderId == orderid || orderid == null
                                      select new
                                      {
                                          o.Id,
                                          c.FirstName,
                                          c.LastName,
                                          m.Title,
                                          oi.Quantity,
                                          oi.Cost,
                                          m.ImagePath,
                                      }).ToList();

                    orderitems.ForEach(oi => rows.Add(new Models.OrderItem
                    {
                        Id = oi.Id,
                        CustomerName = oi.FirstName + ", " + oi.LastName,
                        MovieTitle= oi.Title,
                        Quantity = oi.Quantity,
                        Cost = oi.Cost,
                        ImagePath = oi.ImagePath,
                    }));

                }
                return rows;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
