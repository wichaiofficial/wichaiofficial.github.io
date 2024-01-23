using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore.Storage;
using System.Linq;
using WX.DVDCentral.PL;

namespace WX.DVDCentral.PL.Test
{
    [TestClass]
    public class utUser
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
            // How many I expected
            int expected = 0;
            // How many I did get back
            int actual;


            // Get the rows.  SELECT * FROM tblUser
            // var rows = from s in dc.tblUsers;
            var rows = dc.tblUsers;


            actual = rows.Count();

            // Test to see if I got the right amount.
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void InsertTest()
        {
            // Create a new row in memory
            tblUser newrow = new tblUser();

            // Set the properties
            newrow.Id = -99;
            newrow.FirstName = "Me";
            newrow.LastName = "Smith";
            newrow.UserName = "dkjfkldsjf";
            newrow.Password = "asdf";

            // Insert the row into the table.
            dc.tblUsers.Add(newrow);
            int result = dc.SaveChanges();

            Assert.IsTrue(result == 1);

        }

        [TestMethod]
        public void UpdateTest()
        {
            InsertTest();

            // Get a row to update
            // SELECT * FROM tblUser s where Id = 2
            tblUser row = (from s in dc.tblUsers
                           where s.Id == 1
                           select s).FirstOrDefault();


            if (row != null)
            {
                // Set the properties
                row.FirstName = "Test";
                row.LastName = "Test";

                // Update the row into the table.
                int result = dc.SaveChanges();

                Assert.IsTrue(result == 1);
            }
        }

        [TestMethod]
        public void DeleteTest()
        {
            InsertTest();

            // Get a row to update
            // SELECT * FROM tblUser s where Id = 2
            tblUser row = (from s in dc.tblUsers
                           where s.Id == 1
                           select s).FirstOrDefault();


            if (row != null)
            {

                // Delete the row into the table.
                dc.tblUsers.Remove(row);
                int result = dc.SaveChanges();

                Assert.AreNotEqual(0, result);
            }
        }
    }
}