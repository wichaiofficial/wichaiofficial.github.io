using Microsoft.EntityFrameworkCore.Storage;
using System.Transactions;
using WX.DVDCentral.PL;

namespace WX.DVDCentral.PL.Test
{
    [TestClass]
    public class utMovie
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
            var rows = dc.tblMovies;
            actual = rows.Count();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertTest()
        {
            tblMovie newrow = new tblMovie();
            newrow.Id = -99;
            newrow.Title = "Jamanji";
            newrow.Description = "My new Movie";
            newrow.Cost = 10;
            newrow.RatingId = -1;
            newrow.FormatId = -1;   
            newrow.DirectorId = -1;
            newrow.InStkQty = -1;
            newrow.ImagePath = "image";
            dc.tblMovies.Add(newrow);
            int result = dc.SaveChanges();
            Assert.IsTrue(result == 1);
        }

        [TestMethod]

        public void UpdateTest()
        {
            tblMovie row = (from s in dc.tblMovies
                            where s.Id == 2
                            select s).FirstOrDefault();
            if (row != null)
            {             
                row.Description = "My new Movie";
                
                int result = dc.SaveChanges();

                Assert.IsTrue(result == 1);
            }
        }

        [TestMethod]

        public void DeleteTest()
        {
            tblMovie row = (from dt in dc.tblMovies
                            where dt.Id == 2
                            select dt).FirstOrDefault();
            if (row != null)
            {
                dc.tblMovies.Remove(row);
                int result = dc.SaveChanges();
                Assert.AreNotEqual(0, result);
            }
        }
    }
}