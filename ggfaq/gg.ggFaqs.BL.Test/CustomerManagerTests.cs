using gg.ggFaqs.BL.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gg.ggFaqs.BL.Test
{
    [TestClass]
    public class CustomerManagerTests
    {
        [TestMethod]
        public void LoadTest()
        {
            Assert.IsTrue(CustomerManager.Load().Count > 0);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            Assert.AreEqual(1, CustomerManager.LoadById(1).Id);
        }

        [TestMethod]
        public void LoginTest()
        {
            Customer customer = CustomerManager.LoadById(1);

            Assert.IsTrue(CustomerManager.Login(customer.Username, customer.Password));
        }

        [TestMethod]
        public void InsertTest()
        {
            Customer customer = new Customer
            {
                Id = -1,
                FirstName = "Test",
                LastName = "Test",
                Username = "Test",
                Password = "Test",
                Address = "Test",
                City = "Test",
                State = "TE",
                ZipCode = "Test",
                Phone = "Test",
                DisplayName = "Test",
                ProfileImage = "Test",
                AboutMe = "Test",
                SocialSites = "Test"
            };

            Assert.AreEqual(1, CustomerManager.Insert(customer, true));
        }

        [TestMethod]
        public void UpdateTest()
        {
            Customer customer = CustomerManager.LoadById(1);

            customer.FirstName = "Test";

            Assert.AreEqual(1, CustomerManager.Update(customer, true));
        }

        [TestMethod]
        public void DeleteTest()
        {
            Customer customer = new Customer
            {
                FirstName = "Test",
                LastName = "Test",
                Username = "Test",
                Password = "Test",
                Address = "Test",
                City = "Test",
                State = "TE",
                ZipCode = "Test",
                Phone = "Test",
                DisplayName = "Test",
                ProfileImage = "Test",
                AboutMe = "Test",
                SocialSites = "Test"
            };

            int id = CustomerManager.Insert(customer);
            Customer delete = CustomerManager.Load().Last();

            Assert.IsTrue(CustomerManager.Delete(delete.Id) > 0);
        }
    }
}
