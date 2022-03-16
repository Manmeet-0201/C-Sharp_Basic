using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceDemo;
namespace InterfaceDemo
{
    class InterfaceDemoExecutor
    {
        static void Main(string[] args)
        {
            ImplementationByUserA SignupPageImplementation = new ImplementationByUserA();
            bool UsernameVerification = SignupPageImplementation.IsUsernameAvailable("arjun123");
            bool passwordVerification = SignupPageImplementation.IsUsernameAvailable("123545");//
            

            if (UsernameVerification && passwordVerification)
            {
                //User is redirected to home page
            }
            else
            {
                //User is not allowed to move to the home page
            }
        }
    }
}
