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
    public class LibraryGameTest
    {
        [TestMethod]
        public void LoadTest()
        {
            Assert.IsTrue(LibraryGameManager.Load().Count > 0);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            Assert.AreEqual(1, LibraryGameManager.LoadById(1).Id);
        }

        [TestMethod]
        public void GamesByLibraryIdTest()
        {
            Assert.AreEqual(3, LibraryGameManager.GamesByLibraryId(1).Count());
        }

        [TestMethod]
        public void InsertTest()
        {
            LibraryGame game = new LibraryGame
            {
                LibraryId = 1,
                GameId = 1,
                DateAdded = DateTime.Now
            };

            Assert.AreEqual(1, LibraryGameManager.Insert(game, true));
        }

        [TestMethod]
        public void UpdateTest()
        {
            LibraryGame game = LibraryGameManager.LoadById(1);

            game.DateAdded = DateTime.Now;

            Assert.AreEqual(1, LibraryGameManager.Update(game, true));
        }

        [TestMethod]
        public void DeleteTest()
        {
            LibraryGame delete = LibraryGameManager.Load().Last();

            Assert.IsTrue(LibraryGameManager.Delete(delete.Id, true) > 0);
        }
    }
}
