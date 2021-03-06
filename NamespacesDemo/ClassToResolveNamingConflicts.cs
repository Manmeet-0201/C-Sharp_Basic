using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RBI_SBI = ReserveBankOfIndia.StateBankOfIndia;
using RBI_CBI = ReserveBankOfIndia.CentralBankOFIndia;
namespace NamespacesDemo
{
    class ClassToResolveNamingConflicts
    {
        static void Main(string[] args)
        {
            // One way to resolve naming conflict is to use the shorthand notation in the using directive 
            bool checkIfPaymentSuccessfulBySBI = RBI_SBI.PaymentProcessing.IsPaymentSuccessful();
            bool checkIfPaymentSuccessfulByCBI = RBI_CBI.PaymentProcessing.IsPaymentSuccessful();

            if (checkIfPaymentSuccessfulBySBI)
            {
                Console.WriteLine("Payment completed successfully by SBI");
            }
            else
            {
                Console.WriteLine("Payment failed by SBI");
            }

            if (checkIfPaymentSuccessfulByCBI)
            {
                Console.WriteLine("Payment completed successfully by CBI");
            }
            else
            {
                Console.WriteLine("Payment failed by CBI");
            }

            //The other way is to use the fully qualified names while calling the methods (which have the same name)

            /*bool checkIfPaymentSuccessfulBySBI = RBI_SBI.PaymentProcessing.IsPaymentSuccessful();
            bool checkIfPaymentSuccessfulByCBI = RBI_CBI.PaymentProcessing.IsPaymentSuccessful();*/
        }
    }
}

namespace ReserveBankOfIndia
{
    namespace StateBankOfIndia
    {
        class PaymentProcessing
        {
            public static bool IsPaymentSuccessful()
            {
                return true;
            }
        }
    }

    namespace CentralBankOFIndia
    {
        class PaymentProcessing
        {
            public static bool IsPaymentSuccessful()
            {
                //Business logic
                return false;
            }
        }
    }
}
