using Microsoft.EntityFrameworkCore.Storage;
using System.Transactions;
using WX.DVDCentral.PL;

namespace WX.DVDCentral.PL.Test
{
    [TestClass]
    public class utGenre
    {
        protected DVDCentralEntities dc;
        protected IDbContextTransaction transaction;

        [TestInitialize]
        public void TestInitialize()
        {
            dc = new DVDCentralEntities();
            transaction = dc.Database.BeginTransaction();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            transaction.Rollback();
            transaction.Dispose();
        }


        [TestMethod]
        public void LoadTest()
        {
            int expected = 14;
            int actual;
            var rows = dc.tblGenres;
            actual = rows.Count();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertTest()
        {
            tblGenre newrow = new tblGenre();
            newrow.Id = -99;
            newrow.Description = "My new Genre";
            dc.tblGenres.Add(newrow);
            int result = dc.SaveChanges();
            Assert.IsTrue(result == 1);
        }

        [TestMethod]

        public void UpdateTest()
        {
            tblGenre row = (from dt in dc.tblGenres
                                 where dt.Id == 2
                                 select dt).FirstOrDefault();
            if (row != null)
            {
                row.Description = "My new Genre";
                int result = dc.SaveChanges();
                Assert.IsTrue(result == 1);
            }
        }

        [TestMethod]

        public void DeleteTest()
        {
            tblGenre row = (from dt in dc.tblGenres
                                 where dt.Id == 2
                                 select dt).FirstOrDefault();
            if (row != null)
            {
                dc.tblGenres.Remove(row);
                int result = dc.SaveChanges();
                Assert.AreNotEqual(0, result);
            }
        }
    }
}