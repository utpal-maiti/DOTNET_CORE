using App_ClassLibrary;

using App_Mvc.Controllers;

using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_MSTest
{
    [TestClass]
    public class HomeControllerUnitTests
    {
        [TestMethod]
        public void Index_UnitTest()
        {
            HomeController h = new HomeController();

            var index = h.Index() as ViewResult;

            Assert.IsNotNull(index, "Index Method is not returning the View");

            string expectedViewName = "TestView";

            Assert.AreEqual(expectedViewName, index.ViewName, "ViewName mismatch");

            Employee emp = new Employee
            {
                Id = 111,
                Name = "Abhishek",
                Location = "Bangalore",
                Salary = 12345
            };

            Employee actEmp = index.Model as Employee;

            Assert.IsNotNull(actEmp, "Employee Model Object is Null");

            Assert.AreEqual(emp.Name, actEmp.Name, "Employee Name mismatch");

            //string name = index.ViewBag.testName;

            //string expectedName = "Pragim";

            //Assert.AreEqual(expectedName, name, "Name mismatch");
        }
    }
}
