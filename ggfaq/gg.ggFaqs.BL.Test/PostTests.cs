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
    public class PostTest
    {
        [TestMethod]
        public void LoadTest()
        {
            Assert.IsTrue(PostManager.Load().Count > 0);
        }

        [TestMethod]
        public void LoadByIdTest()
        {
            Assert.AreEqual(1, PostManager.LoadById(1).Id);
        }

        [TestMethod]
        public void InsertTest()
        {
            Post post = new Post
            {
                Content = "Test",
                Created = DateTime.Now,
                ThreadID = 1,
                CustomerId = 1,
                ImagePath = "Test"
            };

            Assert.AreEqual(1, PostManager.Insert(post, true));
        }

        [TestMethod]
        public void UpdateTest()
        {
            Post post = PostManager.LoadById(1);

            post.Created = DateTime.Now;

            Assert.AreEqual(1, PostManager.Update(post, true));
        }

        [TestMethod]
        public void DeleteTest()
        {
            Post delete = PostManager.Load().Last();

            Assert.IsTrue(PostManager.Delete(delete.Id, true) > 0);
        }
    }
}
