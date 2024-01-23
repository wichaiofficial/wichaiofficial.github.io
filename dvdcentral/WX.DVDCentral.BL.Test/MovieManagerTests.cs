using Microsoft.VisualStudio.TestTools.UnitTesting;
using WX.DVDCentral.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.DVDCentral.BL.Models;
using Microsoft.Data.SqlClient.Server;
using System.IO;

namespace WX.DVDCentral.BL.Test
{
    [TestClass()]
    public class MovieManagerTests
    {
        [TestMethod()]
        public void InsertTest()
        {
            Movie movie = new Movie
            {
                Title = "Test",
                Description = "Test",
                Cost = 10,
                RatingId = 1,
                FormatId = 1,
                DirectorId = 1,
                InStkQty = 1,
                ImagePath = "Test"
            };
            Assert.AreEqual(1, MovieManager.Insert(movie, true));
        }

        [TestMethod()]
        public void LoadTest()
        {
            Assert.AreEqual(3, MovieManager.Load().Count);
        }

        [TestMethod()]
        public void LoadbyIdTest()
        {
            Assert.AreEqual(2, MovieManager.LoadbyId(2).Id);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Movie movie = MovieManager.LoadbyId(2);

            movie.Title = "Test";
            movie.Description = "Test";
            movie.Cost = 10;
            movie.RatingId = 3;
            movie.FormatId = 2;
            movie.DirectorId = 1;
            movie.InStkQty = 5;
            movie.ImagePath = "Test";

            int results = MovieManager.Update(movie, true);
            Assert.AreEqual(1, results);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.AreEqual(1, MovieManager.Delete(1, true));
        }

        [TestMethod()]
        public void LoadByGenreIdTest()
        {
            Assert.AreEqual(3, MovieManager.LoadByGenreId(4).Count);
        }
    }
}