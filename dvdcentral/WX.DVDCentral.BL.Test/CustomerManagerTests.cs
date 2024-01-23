using Microsoft.VisualStudio.TestTools.UnitTesting;
using WX.DVDCentral.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.DVDCentral.BL.Models;
using System.Net;

namespace WX.DVDCentral.BL.Test
{
    [TestClass()]
    public class CustomerManagerTests
    {
        [TestMethod()]
        public void InsertTest()
        {
            Customer customer = new Customer
            {
                FirstName = "John",
                LastName = "Doe",
                Address = "257 New Street Ave",
                City = "New City",
                State = "NS",
                Zip = "54915",
                Phone = "19285344569",
                UserId = 123456789
        };
            Assert.AreEqual(1, CustomerManager.Insert(customer, true));
        }

        [TestMethod()]
        public void LoadTest()
        {
            Assert.AreEqual(3, CustomerManager.Load().Count);
        }

        [TestMethod()]
        public void LoadbyIdTest()
        {
            Assert.AreEqual(3, CustomerManager.LoadbyId(3).Id);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Customer customer = CustomerManager.LoadbyId(2);
                customer.FirstName = "John";
                customer.LastName = "Doe";
                customer.Address = "257 New Street Ave";
                customer.City = "New City";
                customer.State = "NS";
                customer.Zip = "54915";
                customer.Phone = "19285344569";
                customer.UserId = 123456789;

            int results = CustomerManager.Update(customer, true);
            Assert.AreEqual(1, results);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.AreEqual(1, CustomerManager.Delete(1, true));
        }
    }
}