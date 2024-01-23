using Microsoft.EntityFrameworkCore.Storage;
using System.Transactions;
using WX.DVDCentral.PL;

namespace WX.DVDCentral.PL.Test
{
    [TestClass]
    public class utOrderItem
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
            int expected = 6;
            int actual;
            var rows = dc.tblOrderItems;
            actual = rows.Count();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertTest()
        {
            tblOrderItem newrow = new tblOrderItem();
            newrow.Id = -99;
            newrow.OrderId = -1;
            newrow.MovieId = 1;
            newrow.Quantity = 1;
            newrow.Cost = 1;
            dc.tblOrderItems.Add(newrow);
            int result = dc.SaveChanges();
            Assert.IsTrue(result == 1);
        }

        [TestMethod]

        public void UpdateTest()
        {
            tblOrderItem row = (from dt in dc.tblOrderItems
                             where dt.Id == 2
                             select dt).FirstOrDefault();
            if (row != null)
            {
                row.OrderId = 1;
                row.MovieId = 1;
                row.Id = 2;
                row.Quantity = 1;
                row.Cost = 1;

                int result = dc.SaveChanges();
                Assert.IsTrue(result == 1);
            }
        }

        [TestMethod]

        public void DeleteTest()
        {
            tblOrderItem row = (from dt in dc.tblOrderItems
                             where dt.Id == 2
                             select dt).FirstOrDefault();
            if (row != null)
            {
                dc.tblOrderItems.Remove(row);
                int result = dc.SaveChanges();
                Assert.AreNotEqual(0, result);
            }
        }
    }
}