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
    public class utMembership
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
            Assert.IsTrue(dc.tblMemberships.Any());
        }

        [TestMethod]
        public void InsertTest()
        {
            int expected = 1;

            tblMembership newrow = new tblMembership
            {
                Id = dc.tblMemberships.Count() + 1,
                Membership = "Test",
                Description = "Test"
            };

            dc.tblMemberships.Add(newrow);
            int actual = dc.SaveChanges();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateTest()
        {
            int expected = 1;

            tblMembership row = dc.tblMemberships.FirstOrDefault();

            if (row != null)
            {
                row.Membership = "Test";

                dc.tblMemberships.Update(row);
                int actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void DeleteTest()
        {
            int expected = 1;

            tblMembership newrow = new tblMembership
            {
                Id = dc.tblMemberships.Count() + 1,
                Membership = "Test",
                Description = "Test"
            };
            dc.tblMemberships.Add(newrow);
            int actual = dc.SaveChanges();

            if (newrow != null)
            {
                dc.tblMemberships.Remove(newrow);
                actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }
    }
}