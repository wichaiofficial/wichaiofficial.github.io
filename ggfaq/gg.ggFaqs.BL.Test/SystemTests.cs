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
    public class SystemTest
    {
        [TestMethod]
        public void LoadTest()
        {
            Assert.IsTrue(SystemManager.Load().Count > 0);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            Assert.AreEqual(1, SystemManager.LoadById(1).Id);
        }

        [TestMethod]
        public void InsertTest()
        {
            BL.Models.System system = new BL.Models.System
            {
                Name = "test",
                ManufacturerId = 1,
                ReleaseDate = DateTime.Now
            };

            Assert.AreEqual(1, SystemManager.Insert(system, true));
        }

        [TestMethod]
        public void UpdateTest()
        {
            BL.Models.System system = SystemManager.LoadById(1);

            system.Name = "test";

            Assert.AreEqual(1, SystemManager.Update(system, true));
        }

        [TestMethod]
        public void DeleteTest()
        {
            BL.Models.System delete = new BL.Models.System
            {
                Name = "test",
                ManufacturerId = 1,
                ReleaseDate = DateTime.Now
            };

            SystemManager.Insert(delete);
            int id = SystemManager.Load().Last().Id;

            Assert.IsTrue(SystemManager.Delete(id) > 0);
        }
    }
}
