using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite
{
    public class Directory : Entry
    {
        private string _name;
        private List<Entry> _directory = new List<Entry>();
        public Directory(string name)
        {
            _name = name;
        }

        public override string GetName()
        {
            return _name;
        }

        public override int GetSize()
        {
            int size = 0;
            var enumerator = _directory.GetEnumerator();
            while (enumerator.MoveNext())
            {
                size += enumerator.Current.GetSize();
            }
            return size;
        }

        public override Entry Add(Entry entry)
        {
            _directory.Add(entry);
            return this;
        }

        public override void PrintList(string prefix)
        {
            Console.WriteLine($"{prefix}/{this.ToString()}");
            var enumerator = _directory.GetEnumerator();
            while (enumerator.MoveNext())
            {
                enumerator.Current.PrintList($"{prefix}/{_name}");
            }
        }
    }
}
