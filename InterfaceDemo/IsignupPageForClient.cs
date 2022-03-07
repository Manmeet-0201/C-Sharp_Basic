using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface IsignupPageForClient
    {
        bool PasswordVerificationLogic(string password);
        bool IsUsernameAvailable(string username);
    }
}
