using System;
using System.Collections.Generic;
using System.Text;

namespace Calisma
{
    class UserManager:IUserService
    {
        ILoginService _loginService;
       public UserManager(ILoginService loginService)
        {
            _loginService = loginService;
        }
        public void Add(User user)
        {
            if (_loginService.Validate(user)==true) 
            {
                Console.WriteLine("Giriş Yapıldı"); 
            }
            else
            {
                Console.WriteLine("Üzgünüz ,Girişiniz Yapılamadı");
            }
        }
    }
}
