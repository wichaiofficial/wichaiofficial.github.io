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
    public class utGameUserRating
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
            Assert.IsTrue(dc.tblGameUserRatings.Any());
        }

        [TestMethod]
        public void InsertTest()
        {
            int expected = 1;

            tblGameUserRating newrow = new tblGameUserRating
            {
                Id = dc.tblGameUserRatings.Count() + 1,
                UserRating = 3,
                GameId = 1,
                CustomerId = 1
            };

            dc.tblGameUserRatings.Add(newrow);
            int actual = dc.SaveChanges();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateTest()
        {
            int expected = 1;

            tblGameUserRating row = dc.tblGameUserRatings.FirstOrDefault();

            if (row != null)
            {
                row.UserRating = 3;

                dc.tblGameUserRatings.Update(row);
                int actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void DeleteTest()
        {
            int expected = 1;

            tblGameUserRating newrow = new tblGameUserRating
            {
                Id = dc.tblGameUserRatings.Count() + 1,
                UserRating = 3,
                GameId = 1,
                CustomerId = 1
            };
            dc.tblGameUserRatings.Add(newrow);
            int actual = dc.SaveChanges();

            if (newrow != null)
            {
                dc.tblGameUserRatings.Remove(newrow);
                actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }
    }
}