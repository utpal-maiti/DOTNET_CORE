using App_ClassLibrary;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_MSTest
{
    [TestClass]
    public class DiscountHelperUnitTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ApplyDiscount_UnitTests()
        {
            DiscountHelper helper = new DiscountHelper();

            var totalPrice = 5000;

            var expectedPriceAfterDiscount = 4000;

            var actualPriceAfterDiscount = helper.ApplyDiscount(totalPrice);

            Assert.AreEqual(expectedPriceAfterDiscount, actualPriceAfterDiscount,
                "Apply Discount Method is failed for the Total Price of 5000");

            totalPrice = 4000;
            expectedPriceAfterDiscount = 3600;
            actualPriceAfterDiscount = helper.ApplyDiscount(totalPrice);

            Assert.AreEqual(expectedPriceAfterDiscount, actualPriceAfterDiscount,
                "Apply Discount Method is failed for the Total Price of 4000");

            totalPrice = 400;
            expectedPriceAfterDiscount = 400;
            actualPriceAfterDiscount = helper.ApplyDiscount(totalPrice);

            Assert.AreEqual(expectedPriceAfterDiscount, actualPriceAfterDiscount,
                "Apply Discount Method is failed for the Total Price of 400");


            totalPrice = -100;
            helper.ApplyDiscount(totalPrice);
        }
    }
}
