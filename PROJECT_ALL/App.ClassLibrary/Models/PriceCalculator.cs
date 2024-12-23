using App_ClassLibrary.Contracts;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_ClassLibrary
{
    public class PriceCalculator
    {
        IDiscountHelper disc;

        public PriceCalculator(IDiscountHelper d)
        {
            disc = d;
        }

        public decimal CalculateTotalPrice(List<Product> products)
        {
            var totalPrice = products.Sum(p => p.Price * p.Quantity);

            var priceAfterDiscount = disc.ApplyDiscount(totalPrice);

            return priceAfterDiscount;
        }
    }
}
