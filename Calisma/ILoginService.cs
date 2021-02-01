using System;
using System.Collections.Generic;
using System.Text;

namespace Calisma
{
    interface ILoginService
    {
        bool Validate(User user);
    }
}
