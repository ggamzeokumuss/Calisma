using System;
using System.Collections.Generic;
using System.Text;

namespace Calisma
{
    class LoginManager : ILoginService
    {
        public bool Validate(User user)
        {
            if(user.FirstName=="Gamze" && user.LastName=="Okumuş" && user.Password==1234)
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }
    }
}
