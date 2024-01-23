using Microsoft.EntityFrameworkCore.Storage;
using System.Transactions;
using WX.DVDCentral.PL;

namespace WX.DVDCentral.PL.Test
{
    [TestClass]
    public class utOrder
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
            var rows = dc.tblOrders;
            actual = rows.Count();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertTest()
        {
            tblOrder newrow = new tblOrder();
            newrow.Id = -99;
            newrow.CustomerId = 1;
            newrow.OrderDate = DateTime.Now;
            newrow.UserId = 1;
            newrow.ShipDate = DateTime.Now;

            dc.tblOrders.Add(newrow);
            int result = dc.SaveChanges();
            Assert.IsTrue(result == 1);
        }

        [TestMethod]

        public void UpdateTest()
        {
            tblOrder row = (from s in dc.tblOrders
                            where s.Id == 2
                            select s).FirstOrDefault();
            if (row != null)
            {
                row.CustomerId = 1;
                row.OrderDate = DateTime.Now;
                row.UserId = 1;
                row.ShipDate = DateTime.Now;

                int result = dc.SaveChanges();

                Assert.IsTrue(result == 1);
            }
        }

        [TestMethod]

        public void DeleteTest()
        {
            tblOrder row = (from dt in dc.tblOrders
                            where dt.Id == 2
                            select dt).FirstOrDefault();
            if (row != null)
            {
                dc.tblOrders.Remove(row);
                int result = dc.SaveChanges();
                Assert.AreNotEqual(0, result);
            }
        }
    }
}