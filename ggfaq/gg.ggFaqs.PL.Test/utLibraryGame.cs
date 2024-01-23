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
    public class utLibraryGame
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
            Assert.IsTrue(dc.tblLibraryGames.Any());
        }

        [TestMethod]
        public void InsertTest()
        {
            int expected = 1;

            tblLibraryGame newrow = new tblLibraryGame
            {
                Id = dc.tblLibraryGames.Count() + 1,
                LibraryId = 1,
                GameId = 1
            };

            dc.tblLibraryGames.Add(newrow);
            int actual = dc.SaveChanges();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateTest()
        {
            int expected = 1;

            tblLibraryGame row = dc.tblLibraryGames.FirstOrDefault();

            if (row != null)
            {
                row.LibraryId = 1;

                dc.tblLibraryGames.Update(row);
                int actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void DeleteTest()
        {
            int expected = 1;

            tblLibraryGame newrow = new tblLibraryGame
            {
                Id = dc.tblLibraryGames.Count() + 1,
                LibraryId = 1,
                GameId = 1
            };
            dc.tblLibraryGames.Add(newrow);
            int actual = dc.SaveChanges();

            if (newrow != null)
            {
                dc.tblLibraryGames.Remove(newrow);
                actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }
    }
}