using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Directory : Entry
    {
        private string _name;
        private List<Entry> _dir = new List<Entry>();

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
            var it = _dir.GetEnumerator();
            while (it.MoveNext())
            {
                size += it.Current.GetSize();
            }
            return size;
        }

        public override Entry Add(Entry entry)
        {
            _dir.Add(entry);
            return this;
        }

        public override IEnumerator<Entry> Iterator()
        {
            return _dir.GetEnumerator();
        }

        public override void Accept(Visitor v)
        {
            v.Visit(this);
        }
    }
}
