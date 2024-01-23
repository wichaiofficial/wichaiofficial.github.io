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
    public class FormatManagerTests
    {
        [TestMethod()]
        public void InsertTest()
        {
            Format format = new Format
            {
                Description = "Korean Drama"
            };
            Assert.AreEqual(1, FormatManager.Insert(format, true));
        }

        [TestMethod()]
        public void LoadTest()
        {
            Assert.AreEqual(3, FormatManager.Load().Count);
        }

        [TestMethod()]
        public void LoadbyIdTest()
        {
            Assert.AreEqual(3, FormatManager.LoadbyId(3).Id);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Format format = FormatManager.LoadbyId(2);
            format.Description = "Test";
            int results = FormatManager.Update(format, true);
            Assert.AreEqual(1, results);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.AreEqual(1, FormatManager.Delete(1, true));
        }
    }
}