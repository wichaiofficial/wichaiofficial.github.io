using gg.ggFaqs.BL.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gg.ggFaqs.BL.Test
{
    [TestClass]
    public class GenreTest
    {
        [TestMethod]
        public void LoadTest()
        {
            Assert.IsTrue(GenreManager.Load().Count > 0);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            Assert.AreEqual(1, GenreManager.LoadById(1).Id);
        }

        [TestMethod]
        public void InsertTest()
        {
            Genre genre = new Genre
            {
                Name = "test",
                Description = "test",
                IsChecked = true
            };

            Assert.AreEqual(1, GenreManager.Insert(genre, true));
        }

        [TestMethod]
        public void UpdateTest()
        {
            Genre genre = GenreManager.LoadById(1);

            genre.Description = "test";

            Assert.AreEqual(1, GenreManager.Update(genre, true));
        }

        [TestMethod]
        public void DeleteTest()
        {
            Genre delete = GenreManager.Load().Last();

            Assert.IsTrue(GenreManager.Delete(delete.Id, true) > 0);
        }
    }
}
