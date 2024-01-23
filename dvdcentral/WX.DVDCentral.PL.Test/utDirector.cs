using Microsoft.EntityFrameworkCore.Storage;
using System.Transactions;
using WX.DVDCentral.PL;

namespace WX.DVDCentral.PL.Test
{
    [TestClass]
    public class utDirector
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
            var rows = dc.tblDirectors;
            actual = rows.Count();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertTest()
        {
            tblDirector newrow = new tblDirector();
            newrow.Id = -99;
            newrow.FirstName = "Jack";
            newrow.LastName = "London";
            dc.tblDirectors.Add(newrow);
            int result = dc.SaveChanges();
            Assert.IsTrue(result == 1);
        }

        [TestMethod]

        public void UpdateTest()
        {
            tblDirector row = (from dt in dc.tblDirectors
                            where dt.Id == 2
                            select dt).FirstOrDefault();
            if (row != null)
            {
                row.FirstName = "Jack";
                int result = dc.SaveChanges();
                Assert.IsTrue(result == 1);
            }
        }

        [TestMethod]

        public void DeleteTest()
        {
            tblDirector row = (from dt in dc.tblDirectors
                            where dt.Id == 2
                            select dt).FirstOrDefault();
            if (row != null)
            {
                dc.tblDirectors.Remove(row);
                int result = dc.SaveChanges();
                Assert.AreNotEqual(0, result);
            }
        }
    }
}