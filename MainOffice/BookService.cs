using System.Collections.Generic;
using System.Linq;

namespace MainOffice
{
    class BookService
    {
        private List<Book> Books { get; set; }

        public BookService()
        {
            Books = new List<Book>();
        }

        public List<Book> GetBestBooks()
        {
            return Books.Where(x => x.Stars >= 4).ToList();
        }
    }
}
