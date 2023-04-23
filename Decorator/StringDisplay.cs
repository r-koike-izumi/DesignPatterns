using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class StringDisplay : Display
    {
        private string _str;
        public StringDisplay(string str)
        {
            _str = str;
        }

        public override int GetColumns()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); // .NET Core でShift-JISを扱うためのおまじない
            return Encoding.GetEncoding("Shift_JIS").GetByteCount(_str);
        }

        public override int GetRows()
        {
            return 1;
        }

        public override string GetRowText(int row)
        {
            if (row == 0)
            {
                return _str;
            }
            else
            {
                return null;
            }
        }
    }
}
