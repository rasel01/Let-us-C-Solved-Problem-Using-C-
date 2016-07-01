using System;

namespace OOP
{
    class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual void purchase()
        {
            Console.WriteLine("purchasing {0}",Name);
        }

        public static Item GetItem()
        {
            var iteminfo = new Item()
            {
                ID = 1234,
                Name = " Asus Headphone"
            };
            return iteminfo;
        }
    }

    class Software : Item
    {
        public string ISBN { get; set; }
        public override void purchase()
        {
            Console.WriteLine("Software override method gives software name : {0} , software id : {1}, " +
                              "software isbn number : {2} ",Name,ID,ISBN);
        }
    }

    class Hardware : Item
    {
        public string SerialNumber { get; set; }
    }

    class DesktopApp : Software
    {
        public string DomainName { get; set; }
        public string ArecheictureName { get; set; }
    }

    class WebApp : Software
    {
        public string Description { get; set; }
        public string Technologies { get; set; }

    }

    class Computer : Hardware
    {
        public string CpuType { get; set; }
        public string Disks { get; set; }
        public override void purchase()
        {
            base.purchase();
            Console.WriteLine("override method gives {0}",CpuType);
        }
    }

    class Peripherals : Hardware
    {
        public string Configuration { get; set; }
    }
}
