using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            
                var notificationServiceProvider = new NotificationServiceProvider();
                var shippingService = new ShippingService(notificationServiceProvider);
                shippingService.ShipItem();
            
        }

    }
    

    

    

   

    
}
