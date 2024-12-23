using App_ClassLibrary.Contracts;
using App_ClassLibrary;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace App_MSTest
{
    [TestClass]
    public class PriceCalculatorUnitTests
    {
        [TestMethod]
        public void CalculateTotalPrice_Test()
        {
            Mock<IDiscountHelper> mock = new Mock<IDiscountHelper>();

            mock.Setup(e => e.ApplyDiscount(It.Is<decimal>(p => p >= 5000)))
                .Returns<decimal>(x => x * 0.8m);

            mock.Setup(e => e.ApplyDiscount(It.IsInRange<decimal>(1000, 4999, Moq.Range.Inclusive)))
                .Returns<decimal>(x => x * 0.9m);

            mock.Setup(e => e.ApplyDiscount(It.IsInRange<decimal>(0, 999, Moq.Range.Inclusive)))
                .Returns<decimal>(x => x);

            mock.Setup(e => e.ApplyDiscount(It.Is<decimal>(p => p < 0))).Throws<ArgumentOutOfRangeException>();

            PriceCalculator calc = new PriceCalculator(mock.Object);

            var productsList = new List<Product>
            {
                new Product {Quantity=5,Price=1000 }
            };

            var expectedTotalPrice = 4000;

            var actualTotalPrice = calc.CalculateTotalPrice(productsList);

            Assert.AreEqual(expectedTotalPrice, actualTotalPrice,
                "CalculateTotalPrice Method is failed for the Price of 5000");

            productsList = new List<Product>
            {
                new Product {Quantity=4,Price=1000 }
            };

            expectedTotalPrice = 3600;

            actualTotalPrice = calc.CalculateTotalPrice(productsList);

            Assert.AreEqual(expectedTotalPrice, actualTotalPrice,
                "CalculateTotalPrice Method is failed for the Price of 4000");

        }
    }
}
