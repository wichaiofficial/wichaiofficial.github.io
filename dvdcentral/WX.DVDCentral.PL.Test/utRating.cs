using Microsoft.EntityFrameworkCore.Storage;
using System.Transactions;
using WX.DVDCentral.PL;

namespace WX.DVDCentral.PL.Test
{
    [TestClass]
    public class utRating
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
            int expected = 5;
            int actual;
            var rows = dc.tblRatings;
            actual = rows.Count();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertTest()
        {
            tblRating newrow = new tblRating();
            newrow.Id = -99;
            newrow.Description = "My new Rating";
            dc.tblRatings.Add(newrow);
            int result = dc.SaveChanges();
            Assert.IsTrue(result == 1);
        }

        [TestMethod]

        public void UpdateTest()
        {
            tblRating row = (from dt in dc.tblRatings
                            where dt.Id == 2
                            select dt).FirstOrDefault();
            if (row != null)
            {
                row.Description = "My new Rating";
                int result = dc.SaveChanges();
                Assert.IsTrue(result == 1);
            }
        }

        [TestMethod]

        public void DeleteTest()
        {
            tblRating row = (from dt in dc.tblRatings
                            where dt.Id == 2
                            select dt).FirstOrDefault();
            if (row != null)
            {
                dc.tblRatings.Remove(row);
                int result = dc.SaveChanges();
                Assert.AreNotEqual(0, result);
            }
        }
    }
}