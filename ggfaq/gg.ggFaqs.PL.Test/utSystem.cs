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
    public class utSystem
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
            Assert.IsTrue(dc.tblSystems.Any());
        }

        [TestMethod]
        public void InsertTest()
        {
            int expected = 1;

            tblSystem newrow = new tblSystem
            {
                Id = dc.tblSystems.Count() + 1,
                Name = "Test",
                ManufacturerId = 1,
                Release = DateTime.Now
            };

            dc.tblSystems.Add(newrow);
            int actual = dc.SaveChanges();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateTest()
        {
            int expected = 1;

            tblSystem row = dc.tblSystems.FirstOrDefault();

            if (row != null)
            {
                row.Name = "Test";

                dc.tblSystems.Update(row);
                int actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void DeleteTest()
        {
            int expected = 1;

            tblSystem newrow = new tblSystem
            {
                Id = dc.tblSystems.Count() + 1,
                Name = "Test",
                ManufacturerId = 1,
                Release = DateTime.Now
            };
            dc.tblSystems.Add(newrow);
            int actual = dc.SaveChanges();

            if (newrow != null)
            {
                dc.tblSystems.Remove(newrow);
                actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }
    }
}