using Microsoft.VisualStudio.TestTools.UnitTesting;
using WX.DVDCentral.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.DVDCentral.BL.Models;

namespace WX.DVDCentral.BL.Test
{
    [TestClass()]
    public class GenreManagerTests
    {
        [TestMethod()]
        public void InsertTest()
        {
            Genre genre = new Genre
            {
                Description = "Korean Drama"
            };
            Assert.AreEqual(1, GenreManager.Insert(genre, true));
        }

        [TestMethod()]
        public void LoadTest()
        {
            Assert.AreEqual(14, GenreManager.Load().Count);
        }

        [TestMethod()]
        public void LoadbyIdTest()
        {
            Assert.AreEqual(3, GenreManager.LoadbyId(3).Id);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Genre genre = GenreManager.LoadbyId(2);
            genre.Description = "Test";
            int results = GenreManager.Update(genre, true);
            Assert.AreEqual(1, results);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.AreEqual(1, GenreManager.Delete(1, true));
        }
    }
}