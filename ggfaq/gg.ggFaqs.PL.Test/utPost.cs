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
    public class utPost
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
            Assert.IsTrue(dc.tblPosts.Any());
        }

        [TestMethod]
        public void InsertTest()
        {
            int expected = 1;

            tblPost newrow = new tblPost
            {
                Id = dc.tblPosts.Count() + 1,
                Content = "Test",
                ImagePath = "Test",
                Created = DateTime.Now,
                ThreadId = 1,
                CustomerId = 1
            };

            dc.tblPosts.Add(newrow);
            int actual = dc.SaveChanges();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateTest()
        {
            int expected = 1;

            tblPost row = dc.tblPosts.FirstOrDefault();

            if (row != null)
            {
                row.Content = "Test";

                dc.tblPosts.Update(row);
                int actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void DeleteTest()
        {
            int expected = 1;

            tblPost newrow = new tblPost
            {
                Id = dc.tblPosts.Count() + 1,
                Content = "Test",
                ImagePath = "Test",
                Created = DateTime.Now,
                ThreadId = 1,
                CustomerId = 1
            };
            dc.tblPosts.Add(newrow);
            int actual = dc.SaveChanges();

            if (newrow != null)
            {
                dc.tblPosts.Remove(newrow);
                actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }
    }
}