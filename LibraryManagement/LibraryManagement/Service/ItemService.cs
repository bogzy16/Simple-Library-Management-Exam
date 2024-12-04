using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Service
{
    public class ItemService
    {
        private ItemModel _item;

        public ItemService(ItemModel item) 
        {
            _item = item;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Item ID is : {_item.Id}");
            Console.WriteLine($"Item Title is : {_item.Title}");
        }
    }
}
