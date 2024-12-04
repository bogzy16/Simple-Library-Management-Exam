using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Model
{
    public class BookModel : ItemModel
    {
        public string Author {  get; set; }
        public string Isbn { get; set; }
    }
}
