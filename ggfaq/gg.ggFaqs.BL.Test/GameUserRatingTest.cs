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
    public class GameUserRatingTest
    {
        [TestMethod]
        public void LoadTest()
        {
            Assert.IsTrue(GameUserRatingManager.Load().Count > 0);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            Assert.AreEqual(1, GameUserRatingManager.LoadById(1).Id);
        }

        [TestMethod]
        public void InsertTest()
        {
            GameUserRating rating = new GameUserRating
            {
                GameId = 1,
                CustomerId = 1,
                UserRating = 1
            };

            Assert.AreEqual(1, GameUserRatingManager.Insert(rating, true));
        }

        [TestMethod]
        public void UpdateTest()
        {
            GameUserRating rating = GameUserRatingManager.LoadById(1);

            rating.UserRating = 3;

            Assert.AreEqual(1, GameUserRatingManager.Update(rating, true));
        }

        [TestMethod]
        public void DeleteTest()
        {
            GameUserRating delete = GameUserRatingManager.Load().Last();

            Assert.IsTrue(GameUserRatingManager.Delete(delete.Id, true) > 0);
        }
    }
}
