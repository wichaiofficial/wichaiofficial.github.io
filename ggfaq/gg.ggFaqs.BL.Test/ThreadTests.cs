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
    public class ThreadTest
    {
        [TestMethod]
        public void LoadTest()
        {
            Assert.IsTrue(ThreadManager.Load().Count > 0);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            Assert.AreEqual(1, ThreadManager.LoadById(1).Id);
        }

        [TestMethod]
        public void InsertTest()
        {
            BL.Models.Thread thread = new BL.Models.Thread
            {
                Subject = "test",
                Created = DateTime.Now,
                CustomerId = 1,
                GameId = 1
            };

            Assert.AreEqual(1, ThreadManager.Insert(thread, true));
        }

        [TestMethod]
        public void UpdateTest()
        {
            BL.Models.Thread thread = ThreadManager.LoadById(1);

            thread.Subject = "test";

            Assert.AreEqual(1, ThreadManager.Update(thread, true));
        }

        [TestMethod]
        public void DeleteTest()
        {
            BL.Models.Thread delete = new BL.Models.Thread
            {
                Subject = "test",
                Created = DateTime.Now,
                CustomerId = 1,
                GameId = 1
            };

            ThreadManager.Insert(delete);
            int id = ThreadManager.Load().Last().Id;

            Assert.IsTrue(ThreadManager.Delete(id) > 0);
        }
    }
}
