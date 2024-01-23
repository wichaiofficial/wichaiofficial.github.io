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
    public class utGenre
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
            Assert.IsTrue(dc.tblGenres.Any());
        }

        [TestMethod]
        public void InsertTest()
        {
            int expected = 1;

            tblGenre newrow = new tblGenre
            {
                Id = dc.tblGenres.Count() + 1,
                Genre = "Test",
                GenreDescription = "Test"
            };

            dc.tblGenres.Add(newrow);
            int actual = dc.SaveChanges();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateTest()
        {
            int expected = 1;

            tblGenre row = dc.tblGenres.FirstOrDefault();

            if (row != null)
            {
                row.Genre = "Test";

                dc.tblGenres.Update(row);
                int actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void DeleteTest()
        {
            int expected = 1;

            tblGenre newrow = new tblGenre
            {
                Id = dc.tblGenres.Count() + 1,
                Genre = "Test",
                GenreDescription = "Test"
            };
            dc.tblGenres.Add(newrow);
            int actual = dc.SaveChanges();

            if (newrow != null)
            {
                dc.tblGenres.Remove(newrow);
                actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }
    }
}