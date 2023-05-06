using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterInheritance
{
    public interface IPrint
    {
        void PrintWeak();
        void PrintStrong();
    }
}
