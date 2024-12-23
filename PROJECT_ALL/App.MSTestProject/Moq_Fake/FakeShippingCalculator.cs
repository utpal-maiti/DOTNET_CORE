using App_ClassLibrary;
using App_ClassLibrary.Contracts;

namespace App_MSTest.tests
{
    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
