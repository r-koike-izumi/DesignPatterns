using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class PrinterProxy : IPrintable
    {
        private string _name;
        private Printer _real;
        private static object _lockobj = new Object();

        public PrinterProxy() { }

        public PrinterProxy(string name)
        {
            _name = name;
        }

        public string PrinterName
        {
            get
            {
                return _name;
            }
            set
            {
                lock (_lockobj)
                {
                    if (_real != null)
                    {
                        _real.PrinterName = value;
                    }
                }
                _name = value;
            }
        }

        public void Print(string str)
        {
            Realize();
            _real.Print(str);
        }

        private void Realize()
        {
            lock (_lockobj)
            {
                if (_real == null)
                {
                    // 実際に利用するまでインスタンスの生成を遅延させている
                    _real = new Printer(_name);
                }
            }
        }
    }
}
