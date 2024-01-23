using Microsoft.EntityFrameworkCore.Storage;
using System.Transactions;
using WX.DVDCentral.PL;

namespace WX.DVDCentral.PL.Test
{
    [TestClass]
    public class utFormat
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
            int expected = 3;
            int actual;
            var rows = dc.tblFormats;
            actual = rows.Count();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertTest()
        {
            tblFormat newrow = new tblFormat();
            newrow.Id = -99;
            newrow.Description = "My new Format";
            dc.tblFormats.Add(newrow);
            int result = dc.SaveChanges();
            Assert.IsTrue(result == 1);
        }

        [TestMethod]

        public void UpdateTest()
        {
            tblFormat row = (from dt in dc.tblFormats
                            where dt.Id == 2
                            select dt).FirstOrDefault();
            if (row != null)
            {
                row.Description = "My new Format";
                int result = dc.SaveChanges();
                Assert.IsTrue(result == 1);
            }
        }

        [TestMethod]

        public void DeleteTest()
        {
            tblFormat row = (from dt in dc.tblFormats
                            where dt.Id == 2
                            select dt).FirstOrDefault();
            if (row != null)
            {
                dc.tblFormats.Remove(row);
                int result = dc.SaveChanges();
                Assert.AreNotEqual(0, result);
            }
        }
    }
}