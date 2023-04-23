using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Delegate
{
    public abstract class Print
    {
        public abstract void PrintWeak();
        public abstract void PrintStrong();
    }
}
