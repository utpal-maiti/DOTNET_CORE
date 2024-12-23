using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_ClassLibrary.Contracts
{
    public interface IDiscountHelper
    {
        decimal ApplyDiscount(decimal totalPrice);
    }
}
