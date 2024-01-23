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
    public class utManufacturer
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
            Assert.IsTrue(dc.tblManufacturers.Any());
        }

        [TestMethod]
        public void InsertTest()
        {
            int expected = 1;

            tblManufacturer newrow = new tblManufacturer
            {
                Id = dc.tblManufacturers.Count() + 1,
                Name = "Test",
                Address = "Test",
                City = "Test",
                State = "TE",
                Zip = "Test"
            };

            dc.tblManufacturers.Add(newrow);
            int actual = dc.SaveChanges();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateTest()
        {
            int expected = 1;

            tblManufacturer row = dc.tblManufacturers.FirstOrDefault();

            if (row != null)
            {
                row.Name = "Test";

                dc.tblManufacturers.Update(row);
                int actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void DeleteTest()
        {
            int expected = 1;

            tblManufacturer newrow = new tblManufacturer
            {
                Id = dc.tblManufacturers.Count() + 1,
                Name = "Test",
                Address = "Test",
                City = "Test",
                State = "TE",
                Zip = "Test"
            };
            dc.tblManufacturers.Add(newrow);
            int actual = dc.SaveChanges();

            if (newrow != null)
            {
                dc.tblManufacturers.Remove(newrow);
                actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }
    }
}