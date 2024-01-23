using Microsoft.VisualStudio.TestTools.UnitTesting;
using WX.DVDCentral.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.DVDCentral.BL.Models;

namespace WX.DVDCentral.BL.Test
{
    [TestClass()]
    public class OrderManagerTests
    {
        [TestMethod()]
        public void InsertOrderOrderItemTest()
        {
            Order order = new Order
            {
                CustomerId = 1,
                OrderDate = DateTime.Now,
                UserId = 1,
                ShipDate = DateTime.Now,
            };

            order.Orderitem = new List<OrderItem>();
            OrderItem orderItem1 = new OrderItem { Cost = 18, MovieId = 2, Quantity = 2 };
            order.Orderitem.Add(orderItem1);
            OrderItem orderItem2 = new OrderItem { Cost = 9, MovieId = 1, Quantity = 1 };
            order.Orderitem.Add(orderItem2);
            Assert.AreEqual(1, OrderManager.Insert(order, true));
        }

        [TestMethod()]
        public void LoadTest()
        {
            Assert.AreEqual(0, OrderManager.Load().Count);
        }

        [TestMethod()]
        public void LoadByCustomerId()
        {
            Assert.AreEqual(0, OrderManager.Load(2).Count);
        }

        [TestMethod()]
        public void LoadbyIdTest()
        {
            Order order = OrderManager.LoadbyId(1);

            Assert.AreEqual(1, order.Id);
            Assert.AreEqual(3, order.Orderitem.Count );
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Order order = OrderManager.LoadbyId(2);

            order.CustomerId = 1;
            order.OrderDate = DateTime.Now;
            order.UserId = 1;
            order.ShipDate = DateTime.Now;

            int results = OrderManager.Update(order, true);
            Assert.AreEqual(1, results);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.AreEqual(1, OrderManager.Delete(1, true));
        }
    }
}