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
    public class CustomerAddedGameManagerTests
    {
        [TestMethod]
        public void LoadTest()
        {
            Assert.IsTrue(CustomerAddedGameManager.Load().Count > 0);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            Assert.AreEqual(1, CustomerAddedGameManager.LoadById(1).AddedGameId);
        }

        [TestMethod]
        public void InsertTest()
        {
            CustomerAddedGame game = new CustomerAddedGame
            {
                GameTitle = "Test",
                GameDeveloper = "Test",
                CustomerId = 1,
                System = "Test",
                Rating = "Test",
                Genre = "Test",
                InSystem = 0
            };

            Assert.AreEqual(1, CustomerAddedGameManager.Insert(game, true));
        }

        [TestMethod]
        public void UpdateTest()
        {
            CustomerAddedGame game = CustomerAddedGameManager.LoadById(1);

            game.GameTitle = "Test1";

            Assert.AreEqual(1, CustomerAddedGameManager.Update(game, true));
        }

        [TestMethod]
        public void DeleteTest()
        {
            CustomerAddedGame game = new CustomerAddedGame
            {
                GameTitle = "Test",
                GameDeveloper = "Test",
                CustomerId = 1,
                System = "Test",
                Rating = "Test",
                Genre = "Test",
                InSystem = 0
            };

            CustomerAddedGameManager.Insert(game);
            CustomerAddedGame delete = CustomerAddedGameManager.Load().Last();

            Assert.IsTrue(CustomerAddedGameManager.Delete(delete.AddedGameId) > 0);
        }
    }
}
