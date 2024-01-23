using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Security.Cryptography;
using gg.ggFaqs.PL;

namespace TTM.gg.PL.Test
{
    [TestClass]
    public class utCustomer
    {
        protected ggEntities dc;
        protected IDbContextTransaction transaction;

        [TestInitialize]
        public void TestInitialize()
        {
            dc = new ggEntities();
            transaction = dc.Database.BeginTransaction();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            transaction.Rollback();
            transaction.Dispose();
            dc = null;
        }

        [TestMethod]
        public void LoadTest()
        {
            Assert.IsTrue(dc.tblCustomers.Any());
        }

        [TestMethod]
        public void InsertTest()
        {
            int expected = 1;

            tblCustomer newrow = new tblCustomer
            {
                Id = dc.tblCustomers.Count() + 1,
                FirstName = "Test",
                LastName = "Test",
                UserName = "Test",
                Password = "Test",
                Address = "Test",
                City = "Test",
                State = "TE",
                Zip = "Test",
                MembershipId = 1,
                DisplayName = "Test",
                profileImage = "Test"
            };

            dc.tblCustomers.Add(newrow);
            int actual = dc.SaveChanges();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateTest()
        {
            int expected = 1;

            tblCustomer row = dc.tblCustomers.FirstOrDefault();

            if (row != null)
            {
                row.FirstName = "Test";

                dc.tblCustomers.Update(row);
                int actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void DeleteTest()
        {
            int expected = 1;

            tblCustomer row = new tblCustomer()
            {
                Id = dc.tblCustomers.Count() + 1,
                FirstName = "Test",
                LastName = "Test",
                UserName = "Test",
                Password = "Test",
                Address = "Test",
                City = "Test",
                State = "TE",
                Zip = "Test",
                MembershipId = 1,
                DisplayName = "Test",
                profileImage = "Test"
            };
            dc.tblCustomers.Add(row);
            int actual = dc.SaveChanges();

            if (row != null)
            {
                dc.tblCustomers.Remove(row);
                actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }
    }
}