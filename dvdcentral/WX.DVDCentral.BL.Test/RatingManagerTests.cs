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
    public class RatingManagerTests
    {
        [TestMethod()]
        public void InsertTest()
        {
            Rating rating = new Rating
            {
                Description = "Korean Drama"
            };
            Assert.AreEqual(1, RatingManager.Insert(rating, true));
        }

        [TestMethod()]
        public void LoadTest()
        {
            Assert.AreEqual(5, RatingManager.Load().Count);
        }

        [TestMethod()]
        public void LoadbyIdTest()
        {
            Assert.AreEqual(3, RatingManager.LoadbyId(3).Id);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Rating rating = RatingManager.LoadbyId(2);
            rating.Description = "Test";
            int results = RatingManager.Update(rating, true);
            Assert.AreEqual(1, results);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.AreEqual(1, RatingManager.Delete(1, true));
        }
    }
}