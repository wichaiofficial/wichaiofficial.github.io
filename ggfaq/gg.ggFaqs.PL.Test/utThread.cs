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
    public class utThread
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
            Assert.IsTrue(dc.tblThreads.Any());
        }

        [TestMethod]
        public void InsertTest()
        {
            int expected = 1;

            tblThread newrow = new tblThread
            {
                Id = dc.tblThreads.Count() + 1,
                Subject = "Test",
                CustomerId = 1,
                Created = DateTime.Now,
                GameId = 1
            };

            dc.tblThreads.Add(newrow);
            int actual = dc.SaveChanges();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateTest()
        {
            int expected = 1;

            tblThread row = dc.tblThreads.FirstOrDefault();

            if (row != null)
            {
                row.Subject = "Test";

                dc.tblThreads.Update(row);
                int actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void DeleteTest()
        {
            int expected = 1;

            tblThread newrow = new tblThread
            {
                Id = dc.tblThreads.Count() + 1,
                Subject = "Test",
                CustomerId = 1,
                Created = DateTime.Now,
                GameId = 1
            };
            dc.tblThreads.Add(newrow);
            int actual = dc.SaveChanges();

            if (newrow != null)
            {
                dc.tblThreads.Remove(newrow);
                actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }
    }
}