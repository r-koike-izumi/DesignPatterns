using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface IPrintable
    {
        string PrinterName { get; set; }
        void Print(string str);
    }
}
