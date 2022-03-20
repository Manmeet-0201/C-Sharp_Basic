using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    class OrderNotificationSender
    {
        public void SendNotification(string orderValue)
        {
            Console.WriteLine(orderValue+" "+"Notification for order has been sent");
        }
    }
}
