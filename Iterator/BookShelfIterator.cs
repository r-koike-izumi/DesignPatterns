using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class BookShelfIterator : IIterator
    {
        private BookShelf _bookShelf;
        private int _index;

        public BookShelfIterator(BookShelf bookshelf)
        {
            _bookShelf = bookshelf;
            _index = 0;
        }

        public bool HasNext()
        {
            return (_index < _bookShelf.Length());
        }

        public object Next()
        {
            Book book = _bookShelf.BookAt(_index);
            _index++;
            return book;
        }

    }
}
