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
    public class RatingTest
    {
        [TestMethod]
        public void LoadTest()
        {
            Assert.IsTrue(RatingManager.Load().Count > 0);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            Assert.AreEqual(1, RatingManager.LoadById(1).Id);
        }

        [TestMethod]
        public void InsertTest()
        {
            Rating rating = new Rating
            {
                Name = "test",
                Description = "test"
            };

            Assert.AreEqual(1, RatingManager.Insert(rating, true));
        }

        [TestMethod]
        public void UpdateTest()
        {
            Rating rating = RatingManager.LoadById(1);

            rating.Description = "test";

            Assert.AreEqual(1, RatingManager.Update(rating, true));
        }

        [TestMethod]
        public void DeleteTest()
        {
            Rating delete = RatingManager.Load().Last();

            Assert.IsTrue(RatingManager.Delete(delete.Id, true) > 0);
        }
    }
}
