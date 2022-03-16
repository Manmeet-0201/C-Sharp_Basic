using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceDemo;
namespace InheritanceDemo
{
    class InheritanceDemoExecutor
    {
        static void Main(string[] args)
        {
            Iphone AppleProduct = new Iphone();
            AppleProduct.OperatingSystemForIphones();
            AppleProduct.CommunicationFacility();

            Oneplus OneplusProduct = new Oneplus();
            OneplusProduct.OperatingSystemForOneplus();
            OneplusProduct.CameraFeaturesProvidedByMobile();
            Console.ReadKey();
        }
    }
}
