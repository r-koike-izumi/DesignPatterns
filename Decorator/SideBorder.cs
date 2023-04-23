using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SideBorder : Border
    {
        private char _borderChar;

        public SideBorder(Display display, char borderChar) : base(display)
        {
            _borderChar = borderChar;
        }

        public override int GetColumns()
        {
            return 1 + Display.GetColumns() + 1;
        }

        public override int GetRows()
        {
            return Display.GetRows();
        }

        public override string GetRowText(int row)
        {
            return _borderChar + Display.GetRowText(row) + _borderChar;
        }
    }
}
