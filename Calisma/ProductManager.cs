using System;
using System.Collections.Generic;
using System.Text;

namespace Calisma
{
    class ProductManager : IProductService 
    {
        IDiscountService _discountService;
        public ProductManager(IDiscountService discountService)
        {
            _discountService = discountService;
        }
        public void Add(Product product, User user)
        {
           if(_discountService.Coupon(product, user)==true)
            {
                Console.WriteLine("Gamze Okumuş Adlı Kullanıcı İndirimli Pantolon Satın Aldı");
            }
           else
            {
                Console.WriteLine("Üzgünüz İndirim Kuponu Bulunamadı");
            }
        }

        internal void Add(User user, Product product)
        {
            Console.WriteLine(user.FirstName+ " "+ "Adlı Kullanıcı"+" "+ product.Name+" "+ "Uyguladı");
        }
    }
}
