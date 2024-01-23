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
    public class EventThreadManagerTests
    {
        [TestMethod]
        public void LoadTest()
        {
            Assert.IsTrue(EventThreadManager.Load().Count > 0);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            Assert.AreEqual(1, EventThreadManager.LoadById(1).Id);
        }

        [TestMethod]
        public void InsertTest()
        {
            EventThread thread = new EventThread
            {
                EventName = "Test",
                EventDate = DateTime.Today,
                CustomerId = 1,
                Online = 1,
                Zip = "Test",
                Active = 1
            };

            Assert.AreEqual(1, EventThreadManager.Insert(thread, true));
        }

        [TestMethod]
        public void UpdateTest()
        {
            EventThread thread = EventThreadManager.LoadById(1);

            thread.EventName = "Test2";

            Assert.AreEqual(1, EventThreadManager.Update(thread, true));
        }

        [TestMethod]
        public void DeleteTest()
        {
            EventThread thread = new EventThread
            {
                EventName = "Test",
                EventDate = DateTime.Today,
                CustomerId = 1,
                Online = 1,
                Zip = "Test",
                Active = 1
            };

            EventThreadManager.Insert(thread);
            EventThread delete = EventThreadManager.Load().Last();

            Assert.IsTrue(EventThreadManager.Delete(delete.Id) > 0);
        }
    }
}
