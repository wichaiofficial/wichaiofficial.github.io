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
    public class utFollowingThread
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
            Assert.IsTrue(dc.tblFollowingThreads.Any());
        }

        [TestMethod]
        public void InsertTest()
        {
            int expected = 1;

            tblFollowingThread newrow = new tblFollowingThread
            {
                Id = dc.tblFollowingThreads.Count() + 1,
                CustomerId = 1,
                ThreadId = 1,
                Following = 1
            };

            dc.tblFollowingThreads.Add(newrow);
            int actual = dc.SaveChanges();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateTest()
        {
            int expected = 1;

            tblFollowingThread row = dc.tblFollowingThreads.FirstOrDefault();

            if (row != null)
            {
                row.Following = 0;

                dc.tblFollowingThreads.Update(row);
                int actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void DeleteTest()
        {
            int expected = 1;

            tblFollowingThread newrow = new tblFollowingThread
            {
                Id = dc.tblFollowingThreads.Count() + 1,
                CustomerId = 1,
                ThreadId = 1,
                Following = 1
            };
            dc.tblFollowingThreads.Add(newrow);
            int actual = dc.SaveChanges();

            if (newrow != null)
            {
                dc.tblFollowingThreads.Remove(newrow);
                actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }
    }
}