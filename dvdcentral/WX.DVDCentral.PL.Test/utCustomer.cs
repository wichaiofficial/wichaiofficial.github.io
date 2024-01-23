using Microsoft.EntityFrameworkCore.Storage;
using System.Data;
using System.Transactions;
using WX.DVDCentral.PL;

namespace WX.DVDCentral.PL.Test
{
    [TestClass]
    public class utCustomer
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
            var rows = dc.tblCustomers;
            actual = rows.Count();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertTest()
        {
            tblCustomer newrow = new tblCustomer();
            newrow.Id = -99;
            newrow.FirstName = "John";
            newrow.LastName = "Doe";
            newrow.Address = "257 New Street Ave";
            newrow.City = "New City";
            newrow.State = "NS";
            newrow.Zip = "54915";
            newrow.Phone = "19285344569";
            newrow.UserId = 123456789;

            dc.tblCustomers.Add(newrow);
            int result = dc.SaveChanges();
            Assert.IsTrue(result == 1);
        }

        [TestMethod]

        public void UpdateTest()
        {
            tblCustomer row = (from s in dc.tblCustomers
                            where s.Id == 2
                            select s).FirstOrDefault();
            if (row != null)
            {
                row.FirstName = "John";
                row.LastName = "Doe";
                row.Address = "257 New Street Ave";
                row.City = "New City";
                row.State = "NS";
                row.Zip = "54915";
                row.Phone = "19285344569";
                row.UserId = 123456789;

                int result = dc.SaveChanges();

                Assert.IsTrue(result == 1);
            }
        }

        [TestMethod]

        public void DeleteTest()
        {
            tblCustomer row = (from dt in dc.tblCustomers
                            where dt.Id == 2
                            select dt).FirstOrDefault();
            if (row != null)
            {
                dc.tblCustomers.Remove(row);
                int result = dc.SaveChanges();
                Assert.AreNotEqual(0, result);
            }
        }
    }
}