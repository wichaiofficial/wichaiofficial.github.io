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
    public class OrderItemManagerTests
    {
        [TestMethod()]
        public void InsertTest()
        {
            OrderItem orderitem = new OrderItem
            {
                OrderId = 1,
                MovieId = 1
            };
            Assert.AreEqual(1, OrderItemManager.Insert(orderitem, true));
        }

        [TestMethod()]
        public void LoadTest()
        {
            Assert.AreEqual(1, OrderItemManager.Load(1).Count);
        }

        [TestMethod()]
        public void LoadbyIdTest()
        {
            Assert.AreEqual(3, OrderItemManager.LoadbyId(3).Id);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            OrderItem orderitem = OrderItemManager.LoadbyId(1);
            orderitem.OrderId = 1;
            orderitem.MovieId = 1;
            int results = OrderItemManager.Update(orderitem, true);
            Assert.AreEqual(1, results);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.AreEqual(1, OrderItemManager.Delete(1, true));
        }
    }
}