using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Display
    {
        private DisplayImpl _impl;

        public Display(DisplayImpl impl)
        {
            _impl = impl;
        }

        public void Open()
        {
            _impl.RawOpen();
        }

        public void Print()
        {
            _impl.RawPrint();
        }

        public void Close()
        {
            _impl.RawClose();
        }

        public void Show()
        {
            Open();
            Print();
            Close();
        }
    }
}
