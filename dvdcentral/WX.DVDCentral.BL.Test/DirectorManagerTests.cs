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
    public class DirectorManagerTests
    {
        [TestMethod()]
        public void InsertTest()
        {
            Director director = new Director
            {
                FirstName = "Johnny",
                LastName = "Smith"
            };
            Assert.AreEqual(1, DirectorManager.Insert(director, true));
        }

        [TestMethod()]
        public void LoadTest()
        {
            Assert.AreEqual(3, DirectorManager.Load().Count);
        }

        [TestMethod()]
        public void LoadbyIdTest()
        {
            Assert.AreEqual(3, DirectorManager.LoadbyId(3).Id);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Director director = DirectorManager.LoadbyId(2);
            director.FirstName = "Johnny";
            director.LastName = "Smith";
            int results = DirectorManager.Update(director, true);
            Assert.AreEqual(1, results);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.AreEqual(1, DirectorManager.Delete(1, true));
        }
    }
}