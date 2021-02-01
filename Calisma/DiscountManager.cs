using System;
using System.Collections.Generic;
using System.Text;

namespace Calisma
{
    class DiscountManager : IDiscountService
    {
        public bool Coupon(Product product, User user)
        {
            if(user.FirstName=="Gamze"&& user.LastName=="Okumuş" && user.Password==1234 && product.Name=="İndirimli Pantolon")
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public void Coupon(Product product)
        {
            Console.WriteLine(product.Name+ " " +"İNDİRİM UYGULANDI");
        }
    }
}
