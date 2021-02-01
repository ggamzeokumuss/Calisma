using System;

namespace Calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManeger = new UserManager(new LoginManager());
            userManeger.Add(new User { FirstName = "Gamze", LastName = "Okumuş" ,Password=1234});

            DiscountManager discountManager = new DiscountManager();
            discountManager.Coupon(new Product() 
            { 
            
              Name="%10 İndirim Kuponu"
 
            });

            ProductManager productManager = new ProductManager(new DiscountManager());
            productManager.Add(new User {FirstName="Gamze" }, new Product {Name="%10 İndirim Kuponunu"});
        }
    }
}
