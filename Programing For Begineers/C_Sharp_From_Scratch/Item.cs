using System;
using System.Collections.Generic;

namespace C_Sharp_From_Scratch
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //public Item(int Id,string Name)
        //{
        //    this.Id = Id;
        //    this.Name = Name;
        //}

        //public Item()
        //{
        //    // TODO: Complete member initialization
        //}

        //private Item()
        //{
        //    throw new NotImplementedException();
        //}


        public static List<Item> GetItemList(int itemCountValue)
        {
            Random ran = new Random();
            var newItemList = new List<Item>();
            for (int i = 0; i < itemCountValue; i++)
            {
                var newItemobj = new Item
                {
                    Id = ran.Next(),
                    Name = "ItemNo" + ran.Next()
                };
                newItemList.Add(newItemobj);
            }
            return newItemList;

        }
    }
}
