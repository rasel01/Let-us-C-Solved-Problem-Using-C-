using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_From_Scratch
{
    public class ListClass
    {

        public void ListDeclare()
        {
            // declare list :
           List<int> list1 = new List<int>();
            Random ran = new Random();
            // add random numbers to list
            for (int i = 0; i < 5; i++)
            {
                list1.Add(ran.Next());
            }
            Console.WriteLine("\n"+"before sort :");

            foreach (int list in list1)
            {
                Console.WriteLine(list);
            }
            // sort the  list
            list1.Sort();

            // display the list :

            Console.WriteLine("\n"+"after sort :"+"\n");


            foreach (int list in list1)
            {
                Console.WriteLine(list);
            }


        }

        public void GetListOfItem()
        {
            // get the list of item from Item class
            List<Item> myItems =Item.GetItemList(10);

            // Display the item

            foreach (Item items in myItems)
            {
                Console.WriteLine("Item Id : {0} and Item Name : {1}",items.Id,items.Name);
            }

        }
    }
}
