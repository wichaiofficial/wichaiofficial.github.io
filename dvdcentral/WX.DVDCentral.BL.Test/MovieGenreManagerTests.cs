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
    public class MovieGenreManagerTests
    {
        [TestMethod()]
        public void InsertTest()
        {
            Assert.AreEqual(0, MovieGenreManager.Insert( 1, 1, true));
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.AreEqual(0, MovieGenreManager.Delete(1, 1, true));
        }
    }
}