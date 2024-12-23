using App_ClassLibrary;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_MSTest
{
    [TestClass]
    public class UserManagementUnitTests
    {
        [TestMethod]
        public void ValidateLogIn_Test()
        {
            //Arrange
            UserManagement obj = new UserManagement();
            string uName = "Pragim", pwd = "Pragim@123";
            bool expectedResult = true;

            //Act
            bool actualResult = obj.ValidateLogIn(uName, pwd);

            //Assert
            Assert.AreEqual(expectedResult, actualResult, "ValidateLogIn Method is failed for Valid Input");
        }
    }
}
