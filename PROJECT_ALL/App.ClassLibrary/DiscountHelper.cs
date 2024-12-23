using App_ClassLibrary.Contracts;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_ClassLibrary
{
    public class DiscountHelper : IDiscountHelper
    {
        public decimal ApplyDiscount(decimal totalPrice)
        {
            if (totalPrice >= 5000)
            {
                return totalPrice * 0.8m;
            }
            else if (totalPrice >= 1000)
            {
                return totalPrice * 0.9m;
            }
            else if (totalPrice >= 0)
            {
                return totalPrice;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
   
}
