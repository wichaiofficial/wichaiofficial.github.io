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
    public class utLibrary
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
            Assert.IsTrue(dc.tblLibraries.Any());
        }

        [TestMethod]
        public void InsertTest()
        {
            int expected = 1;

            tblLibrary newrow = new tblLibrary
            {
                Id = dc.tblLibraries.Count() + 1,
                CustomerId = 1
            };

            dc.tblLibraries.Add(newrow);
            int actual = dc.SaveChanges();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateTest()
        {
            int expected = 1;

            tblLibrary row = dc.tblLibraries.FirstOrDefault();

            if (row != null)
            {
                row.CustomerId = 1;

                dc.tblLibraries.Update(row);
                int actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void DeleteTest()
        {
            int expected = 1;

            tblLibrary newrow = new tblLibrary
            {
                Id = dc.tblLibraries.Count() + 1,
                CustomerId = 1
            };
            dc.tblLibraries.Add(newrow);
            int actual = dc.SaveChanges();

            if (newrow != null)
            {
                dc.tblLibraries.Remove(newrow);
                actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }
    }
}