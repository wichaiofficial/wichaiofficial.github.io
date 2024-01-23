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
    public class utRating
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
            Assert.IsTrue(dc.tblRatings.Any());
        }

        [TestMethod]
        public void InsertTest()
        {
            int expected = 1;

            tblRating newrow = new tblRating
            {
                Id = dc.tblRatings.Count() + 1,
                Rating = "Test",
                RatingDescription = "Test"
            };

            dc.tblRatings.Add(newrow);
            int actual = dc.SaveChanges();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateTest()
        {
            int expected = 1;

            tblRating row = dc.tblRatings.FirstOrDefault();

            if (row != null)
            {
                row.Rating = "Test";

                dc.tblRatings.Update(row);
                int actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void DeleteTest()
        {
            int expected = 1;

            tblRating newrow = new tblRating
            {
                Id = dc.tblRatings.Count() + 1,
                Rating = "Test",
                RatingDescription = "Test"
            };
            dc.tblRatings.Add(newrow);
            int actual = dc.SaveChanges();

            if (newrow != null)
            {
                dc.tblRatings.Remove(newrow);
                actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }
    }
}