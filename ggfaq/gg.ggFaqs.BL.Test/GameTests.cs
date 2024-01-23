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
    public class GameManagerTests
    {
        [TestMethod]
        public void LoadTest()
        {
            Assert.IsTrue(GameManager.Load().Count > 0);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            Assert.AreEqual(1, GameManager.LoadById(1).Id);
        }

        [TestMethod]
        public void InsertTest()
        {
            Game game = new Game
            {
                Title = "Test",
                ReleaseDate = DateTime.Now,
                SystemId = 1,
                RatingId = 1,
                GenreId = 1,
                PublisherId = 1,
                GameDescriptionId = 1
            };

            Assert.AreEqual(1, GameManager.Insert(game, true));
        }

        [TestMethod]
        public void UpdateTest()
        {
            Game game = GameManager.LoadById(1);

            game.Title = "Test1";

            Assert.AreEqual(1, GameManager.Update(game, true));
        }

        [TestMethod]
        public void DeleteTest()
        {
            Game game = new Game
            {
                Title = "Test",
                ReleaseDate = DateTime.Now,
                SystemId = 1,
                RatingId = 1,
                GenreId = 1,
                PublisherId = 1,
                GameDescriptionId = 1
            };

            int id = GameManager.Insert(game);
            Game delete = GameManager.Load().Last();

            Assert.IsTrue(GameManager.Delete(delete.Id, true) > 0);
        }
    }
}
