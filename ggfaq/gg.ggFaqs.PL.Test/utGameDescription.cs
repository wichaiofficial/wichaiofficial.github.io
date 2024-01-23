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
    public class utGameDescription
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
            Assert.IsTrue(dc.tblGameDescriptions.Any());
        }

        [TestMethod]
        public void InsertTest()
        {
            int expected = 1;

            tblGameDescription newrow = new tblGameDescription
            {
                Id = dc.tblGameDescriptions.Count() + 1,
                Description = "Test"
            };

            dc.tblGameDescriptions.Add(newrow);
            int actual = dc.SaveChanges();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateTest()
        {
            int expected = 1;

            tblGameDescription row = dc.tblGameDescriptions.FirstOrDefault();

            if (row != null)
            {
                row.Description = "Test";

                dc.tblGameDescriptions.Update(row);
                int actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void DeleteTest()
        {
            int expected = 1;

            tblGameDescription newrow = new tblGameDescription
            {
                Id = dc.tblGameDescriptions.Count() + 1,
                Description = "Test"
            };
            dc.tblGameDescriptions.Add(newrow);
            int actual = dc.SaveChanges();

            if (newrow != null)
            {
                dc.tblGameDescriptions.Remove(newrow);
                actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }
    }
}