using System;
using System.Collections.Generic;

namespace InventoryMaintenance
{
    public class InvItemList
    {
        private List<InvItem> invItems;

        public InvItemList()
        {
            invItems = new List<InvItem>();
        }

        public int Count => invItems.Count;

        // Beginning of requested code changes
        public InvItem this[int index]
        {
            get
            {
                if(index < 0 || index >= invItems.Count)
                {
                    throw new ArgumentOutOfRangeException("Invalid index: " + index);
                }
                return invItems[index];
            }
            set
            {
                if(index < 0 || index >= invItems.Count)
                {
                    throw new ArgumentOutOfRangeException("Invalid index: " + index);
                }
                invItems[index] = value;
                Changed(this);
            }
        }

        public static InvItemList operator +(InvItemList itemList, InvItem item)
        {
            itemList.Add(item);
            itemList.Changed(itemList);

            return itemList;
        }

        public static InvItemList operator -(InvItemList itemList, InvItem item)
        {
            itemList.Remove(item);
            itemList.Changed(itemList);

            return itemList;
        }

        public delegate void ChangeHandler(InvItemList itemList);

        public event ChangeHandler Changed;

        // End of code requests
        public void Add(InvItem invItem) => invItems.Add(invItem);

        public void Add(int itemNo, string description, decimal price)
        {
            InvItem i = new InvItem(itemNo, description, price);
            invItems.Add(i);

            // Call delegate
            Changed(this);
        }

        public void Remove(InvItem invItem) => invItems.Remove(invItem);

        public void Fill() => invItems = InvItemDB.GetItems();

        public void Save() => InvItemDB.SaveItems(invItems);
    }
}
