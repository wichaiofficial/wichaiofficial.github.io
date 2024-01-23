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
    public class utEventThread
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
            Assert.IsTrue(dc.tblEventThreads.Any());
        }

        [TestMethod]
        public void InsertTest()
        {
            int expected = 1;

            tblEventThread newrow = new tblEventThread
            {
                Id = dc.tblEventThreads.Count() + 1,
                CustomerId = 1,
                EventName = "Test",
                Online = 1,
                EventDate = DateTime.Now,
                Active = 1
            };

            dc.tblEventThreads.Add(newrow);
            int actual = dc.SaveChanges();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateTest()
        {
            int expected = 1;

            tblEventThread row = dc.tblEventThreads.FirstOrDefault();

            if (row != null)
            {
                row.EventName = "Test";

                dc.tblEventThreads.Update(row);
                int actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void DeleteTest()
        {
            int expected = 1;

            tblEventThread newrow = new tblEventThread
            {
                Id = dc.tblEventThreads.Count() + 1,
                CustomerId = 1,
                EventName = "Test",
                Online = 1,
                EventDate = DateTime.Now,
                Active = 1
            };
            dc.tblEventThreads.Add(newrow);
            int actual = dc.SaveChanges();

            if (newrow != null)
            {
                dc.tblEventThreads.Remove(newrow);
                actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }
    }
}