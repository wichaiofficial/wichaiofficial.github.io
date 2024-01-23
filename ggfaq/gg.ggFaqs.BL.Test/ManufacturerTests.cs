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
    public class ManufacturerTest
    {
        [TestMethod]
        public void LoadTest()
        {
            Assert.IsTrue(ManufacturerManager.Load().Count > 0);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            Assert.AreEqual(1, ManufacturerManager.LoadById(1).Id);
        }

        [TestMethod]
        public void InsertTest()
        {
            Manufacturer manufacturer = new Manufacturer
            {
                Name = "Test",
                Address = "Test",
                City = "Test",
                State = "TE",
                Zip = "12345"
            };

            Assert.AreEqual(1, ManufacturerManager.Insert(manufacturer, true));
        }

        [TestMethod]
        public void UpdateTest()
        {
            Manufacturer manufacturer = ManufacturerManager.LoadById(1);

            manufacturer.Name = "Test";

            Assert.AreEqual(1, ManufacturerManager.Update(manufacturer, true));
        }

        [TestMethod]
        public void DeleteTest()
        {
            Manufacturer delete = new Manufacturer
            {
                Name = "Test",
                Address = "Test",
                City = "Test",
                State = "TE",
                Zip = "12345"
            };

            ManufacturerManager.Insert(delete);
            int id = ManufacturerManager.Load().Last().Id;

            Assert.IsTrue(ManufacturerManager.Delete(id) > 0);
        }
    }
}
