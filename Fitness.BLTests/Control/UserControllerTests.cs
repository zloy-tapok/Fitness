using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fitness.BL.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.BL.Control.Tests
{
    [TestClass()]
    public class UserControllerTests


    {
      
        [TestMethod()]
        public void SaveTest()
        {
            var userName = Guid.NewGuid().ToString();
            var controller = new UserController(userName);
            Assert.AreEqual(userName, controller.CurrentUser.Name);
        }

        [TestMethod()]
        public void SetNewUserDataTest()
        {
            var userName = Guid.NewGuid().ToString();
            var birthday = DateTime.Now.AddYears(-18);
            var weight = 90;
            var height = 170;
            var gender = "man";
            var controller = new UserController(userName);
            controller.SetNewUserData(gender, birthday, weight, height);
            var controller2 = new UserController(userName);
            Assert.AreEqual(userName, controller2.CurrentUser.Name);
            Assert.AreEqual(gender, controller2.CurrentUser.Gender.Name);
            Assert.AreEqual(birthday, controller2.CurrentUser.BirthDay);
            Assert.AreEqual(weight, controller2.CurrentUser.Weight);
            Assert.AreEqual(height, controller2.CurrentUser.Height);
        }
    }
}