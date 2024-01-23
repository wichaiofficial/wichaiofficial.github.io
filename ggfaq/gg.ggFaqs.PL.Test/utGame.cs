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
    public class utGame
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
            Assert.IsTrue(dc.tblGames.Any());
        }

        [TestMethod]
        public void InsertTest()
        {
            int expected = 1;

            tblGame newrow = new tblGame
            {
                Id = dc.tblGames.Count() + 1,
                Title = "Test",
                SystemId = 1,
                RatingId = 1,
                GenreId = 1,
                GameDeveloperId = 1,
                GameDescriptionId = 1,
                Release = DateTime.Now,
                ImagePath = "None"
            };

            dc.tblGames.Add(newrow);
            int actual = dc.SaveChanges();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateTest()
        {
            int expected = 1;

            tblGame row = dc.tblGames.FirstOrDefault();

            if (row != null)
            {
                row.Title = "Test";

                dc.tblGames.Update(row);
                int actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void DeleteTest()
        {
            int expected = 1;

            tblGame newrow = new tblGame
            {
                Id = dc.tblGames.Count() + 1,
                Title = "Test",
                SystemId = 1,
                RatingId = 1,
                GenreId = 1,
                GameDeveloperId = 1,
                GameDescriptionId = 1,
                Release = DateTime.Now,
                ImagePath = "NBA2k23.png"
            };
            dc.tblGames.Add(newrow);
            int actual = dc.SaveChanges();

            if (newrow != null)
            {
                dc.tblGames.Remove(newrow);
                actual = dc.SaveChanges();

                Assert.AreEqual(expected, actual);
            }
        }
    }
}