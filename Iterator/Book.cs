using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Book
    {
        public string Name { get; private set; }

        public Book(string name)
        {
            this.Name = name;
        }
    }
}
