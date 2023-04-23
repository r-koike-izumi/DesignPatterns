using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Border : Display
    {
        protected Display Display;
        protected Border(Display display)
        {
            Display = display;
        }
    }
}
