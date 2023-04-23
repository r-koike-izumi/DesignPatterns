using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class FullBorder : Border
    {
        public FullBorder(Display display) : base(display) { }

        public override int GetColumns()
        {
            return 1 + Display.GetColumns() + 1;
        }

        public override int GetRows()
        {
            return 1 + Display.GetRows() + 1;
        }

        public override string GetRowText(int row)
        {
            if (row == 0)
            {
                return "+" + MakeLine('-', Display.GetColumns()) + "+";
            }
            else if (row == Display.GetRows() + 1)
            {
                return "+" + MakeLine('-', Display.GetColumns()) + "+";
            }
            else
            {
                return "|" + Display.GetRowText(row - 1) + "|";
            }
        }


        private string MakeLine(char ch, int count)
        {
            StringBuilder sb = new StringBuilder();
            for(int  i = 0; i < count; i++)
            {
                sb.Append(ch);
            }
            return sb.ToString();
        }
    }
}
