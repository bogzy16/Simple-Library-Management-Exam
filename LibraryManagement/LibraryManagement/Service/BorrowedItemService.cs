using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Service
{
    public class BorrowedItemService
    {
        public string _memberName;
        private List<ItemModel> _items;

        public BorrowedItemService(string MemberName)
        {
            _memberName = MemberName;
            _items = new List<ItemModel>();
        }

        public void BorrowItem(ItemModel item)
        {
            _items.Add(item);
            Console.WriteLine($"{_memberName} borrowed an Item with a Title of {item.Title}");
            Console.WriteLine("");
        }

        public void ReturnItem(ItemModel item) 
        {
            _items.Remove(item);
            Console.WriteLine($"{_memberName} returned the Item with a Title of {item.Title}");
            Console.WriteLine("");
        }

        public void DisplayBorrowedItems()
        {
            if (_items.Count == 0)
            {
                Console.WriteLine($"{_memberName} has no borrowed item.");
            } else
            {
                Console.WriteLine($"{_memberName} borrowed the following items:");

                foreach (var item in _items)
                {
                    ItemService itemService = new ItemService(item);
                    itemService.DisplayDetails();
                    Console.WriteLine("--------------------");
                }
            }
        }
    }
}
