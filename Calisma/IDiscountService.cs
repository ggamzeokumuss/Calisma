using System;
using System.Collections.Generic;
using System.Text;

namespace Calisma
{
    interface IDiscountService
    {
        bool Coupon(Product product, User user);
    }
}
