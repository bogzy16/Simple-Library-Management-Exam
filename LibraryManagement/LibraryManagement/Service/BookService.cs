using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Service
{
    public class BookService: ItemService
    {
        private BookModel _book;
        public BookService(BookModel book) : base(book)
        {
            _book = book;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"The Book Author is : {_book.Author}");
            Console.WriteLine($"The Book ISBN is : {_book.Isbn}");
        }
    }
}
