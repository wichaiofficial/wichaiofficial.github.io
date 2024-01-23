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
    public class EventPostManagerTests
    {
        [TestMethod]
        public void LoadTest()
        {
            Assert.IsTrue(EventPostManager.Load().Count > 0);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            Assert.AreEqual(1, EventPostManager.LoadById(1).Id);
        }

        [TestMethod]
        public void InsertTest()
        {
            EventPost post = new EventPost
            {
                Content = "Test",
                Created = DateTime.Today,
                EventThreadId = 1,
                CustomerId = 1,
                ImagePath = "Test"
            };

            Assert.AreEqual(1, EventPostManager.Insert(post, true));
        }

        [TestMethod]
        public void UpdateTest()
        {
            EventPost post = EventPostManager.LoadById(1);

            post.Content = "Test2";

            Assert.AreEqual(1, EventPostManager.Update(post, true));
        }

        [TestMethod]
        public void DeleteTest()
        {
            Assert.IsTrue(EventPostManager.Delete(1, true) > 0);
        }
    }
}
