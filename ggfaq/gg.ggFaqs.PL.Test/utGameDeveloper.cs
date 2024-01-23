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
    public class utGameDeveloper
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
            Assert.IsTrue(dc.tblGameDevelopers.Any());
        }

        [TestMethod]
        public void InsertTest()
        {
            int expected = 1;

            tblGameDeveloper newrow = new tblGameDeveloper
            {
                Id = dc.tblGameDevelopers.Count() + 1,
                DeveloperName = "Test",
                DateEstablished = DateTime.Now
            };

            dc.tblGameDevelopers.Add(newrow);
            int actual = dc.SaveChanges();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateTest()
        {
            int expected = 1;

            tblGameDeveloper row = dc.tblGameDevelopers.FirstOrDefault();

            if (row != null)
            {
                row.DeveloperName = "Test";

                dc.tblGameDevelopers.Update(row);
                int actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void DeleteTest()
        {
            int expected = 1;

            tblGameDeveloper newrow = new tblGameDeveloper
            {
                Id = dc.tblGameDevelopers.Count() + 1,
                DeveloperName = "Test",
                DateEstablished = DateTime.Now
            };
            dc.tblGameDevelopers.Add(newrow);
            int actual = dc.SaveChanges();

            if (newrow != null)
            {
                dc.tblGameDevelopers.Remove(newrow);
                actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }
    }
}