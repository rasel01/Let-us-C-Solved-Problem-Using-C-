namespace OOP
{
    class WareHouse
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public WareHouse(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }

        public Item FindAndReturnItem(int itemID)
        {
            Item itemobj = new Item();

            itemobj.ID = 101;
            itemobj.Name = "rasel office order";
            return itemobj;

        }
    }
}
