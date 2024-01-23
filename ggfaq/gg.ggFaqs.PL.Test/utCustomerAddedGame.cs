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
    public class utCustomerAddedGame
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
            Assert.IsTrue(dc.tblCustomerAddedGames.Any());
        }

        [TestMethod]
        public void InsertTest()
        {
            int expected = 1;

            tblCustomerAddedGame newrow = new tblCustomerAddedGame
            {
                AddGameId = dc.tblCustomerAddedGames.Count() + 1,
                CustomerId = 1,
                GameTitle = "Test",
                System = "Test",
                InSystem = 0
            };

            dc.tblCustomerAddedGames.Add(newrow);
            int actual = dc.SaveChanges();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateTest()
        {
            int expected = 1;

            tblCustomerAddedGame row = dc.tblCustomerAddedGames.FirstOrDefault();

            if (row != null)
            {
                row.GameTitle = "Test";

                dc.tblCustomerAddedGames.Update(row);
                int actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void DeleteTest()
        {
            int expected = 1;

            tblCustomerAddedGame newrow = new tblCustomerAddedGame
            {
                AddGameId = dc.tblCustomerAddedGames.Count() + 1,
                CustomerId = 1,
                GameTitle = "Test",
                System = "Test",
                InSystem = 0
            };
            dc.tblCustomerAddedGames.Add(newrow);
            int actual = dc.SaveChanges();

            if (newrow != null)
            {
                dc.tblCustomerAddedGames.Remove(newrow);
                actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }
    }
}