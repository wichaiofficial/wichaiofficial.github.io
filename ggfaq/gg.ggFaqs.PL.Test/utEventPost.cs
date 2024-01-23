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
    public class utEventPost
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
            Assert.IsTrue(dc.tblEventPosts.Any());
        }

        [TestMethod]
        public void InsertTest()
        {
            int expected = 1;

            tblEventPost newrow = new tblEventPost
            {
                Id = dc.tblEventPosts.Count() + 1,
                CustomerId = 1,
                Content = "Test",
                EventThreadId = 1,
                Created = DateTime.Now
            };

            dc.tblEventPosts.Add(newrow);
            int actual = dc.SaveChanges();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateTest()
        {
            int expected = 1;

            tblEventPost row = dc.tblEventPosts.FirstOrDefault();

            if (row != null)
            {
                row.Content = "Test";

                dc.tblEventPosts.Update(row);
                int actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void DeleteTest()
        {
            int expected = 1;

            tblEventPost newrow = new tblEventPost
            {
                Id = dc.tblEventPosts.Count() + 1,
                CustomerId = 1,
                Content = "Test",
                EventThreadId = 1,
                Created = DateTime.Now
            };
            dc.tblEventPosts.Add(newrow);
            int actual = dc.SaveChanges();

            if (newrow != null)
            {
                dc.tblEventPosts.Remove(newrow);
                actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }
    }
}