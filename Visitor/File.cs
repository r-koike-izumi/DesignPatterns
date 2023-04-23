using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class File : Entry
    {
        private string _name;
        private int _size;

        public File(string name, int size)
        {
            _name = name;
            _size = size;
        }

        public override string GetName()
        {
            return _name;
        }

        public override int GetSize()
        {
            return _size;
        }

        public override Entry Add(Entry entry)
        {
            throw new FileTreatmentException();
        }

        public override IEnumerator<Entry> Iterator()
        {
            throw new FileTreatmentException();
        }

        public override void Accept(Visitor v)
        {
            v.Visit(this);
        }
    }
}
