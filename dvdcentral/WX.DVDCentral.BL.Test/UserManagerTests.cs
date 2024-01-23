using Microsoft.VisualStudio.TestTools.UnitTesting;
using WX.DVDCentral.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.DVDCentral.BL.Models;
using System.Diagnostics;

namespace WX.DVDCentral.BL.Tests
{
    [TestClass()]
    public class UserManagerTests
    {
        [TestMethod()]
        public void DeleteAllTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InsertTest()
        {
            User user = new User();
            user.FirstName = "Clark";
            user.LastName = "Kent";
            user.UserName = "cKent";
            user.Password = "superman";
            int actual = UserManager.Insert(user, true);

            Assert.AreEqual(1, actual);

        }

        [TestMethod]
        public void LoginSuccededTest()
        {
            try
            {
                UserManager.Seed();
                Assert.IsTrue(UserManager.Login(new User { UserName = "Vthoj21", Password = "soccer" }));
                UserManager.DeleteAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [TestMethod]
        public void LoginFailedTest()
        {
            try
            {
                UserManager.Seed();
                UserManager.Login(new User { UserName = "bfoote", Password = "maple1" });
                Assert.Fail();

            }
            catch (LoginFailureException)
            {
                Debug.WriteLine("LoginFailureException");
                Assert.IsTrue(true);
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Assert.Fail();
            }
            UserManager.DeleteAll();

        }

        [TestMethod()]
        public void LoginTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void seedTest()
        {
            Assert.Fail();
        }
    }
}