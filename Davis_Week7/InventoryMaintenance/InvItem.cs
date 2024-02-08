namespace InventoryMaintenance
{
    public class InvItem
    {
        public int ItemNo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public InvItem() { }
        public InvItem(int itemNo, string description, decimal price)
        {
            ItemNo = itemNo;
            Description = description;
            Price = price;
        }

        public string GetDisplayText()
        {
            return ItemNo + "    " + Description + " ($" + Price.ToString("0.00") + ")";
        }

    }
}