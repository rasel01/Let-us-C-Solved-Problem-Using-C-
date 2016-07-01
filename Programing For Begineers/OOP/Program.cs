using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------old logic---------//

            //WareHouse wh = new WareHouse(101,"warehouse 1");
            //var itemInfo = wh.FindAndReturnItem(101);
            //Console.WriteLine("Item name is : {0}",itemInfo.Name);


            // --- old logic --------------//

            //var mypc = new Computer();
            //mypc.ID = 101;

            //Item mypc2 = new Computer();
            //mypc2.ID = 1001;

            //Computer mypc3 = mypc2 as Computer;
            //mypc3.CpuType = "Core i3";
            //string type = mypc3.CpuType;

            //mypc3.Name = "Windows OS";
            //mypc3.purchase();


            //Software mySoftware = new Software();
            //mySoftware.ID = 011;
            //mySoftware.ISBN = "1234";
            //mySoftware.Name = "Bipuni Bitan.Com";
            //mySoftware.purchase();


            //----- new logic --------

            Item newiteItem = Item.GetItem();
            Console.WriteLine("New item id : {0} , name : {1}",newiteItem.ID,newiteItem.Name);






            Console.ReadKey();
        }
    }
}
