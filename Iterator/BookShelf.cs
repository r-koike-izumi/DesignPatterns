using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class BookShelf : IAggregate
    {
        private List<Book> _books = new List<Book>();
        private int _last = 0;

        public Book BookAt(int index)
        {
            return _books[index];
        }

        public void AppendBook(Book book)
        {
            _books.Add(book);
            _last++;
        }

        public int Length()
        {
            return _last;
        }

        public IIterator Iterator()
        {
            return new BookShelfIterator(this);
        }

    }
}
