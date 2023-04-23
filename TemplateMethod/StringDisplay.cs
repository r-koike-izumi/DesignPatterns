using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class StringDisplay : AbstractDisplay
    {
        private string _str;
        private int _width;

        public StringDisplay(string str)
        {
            _str = str;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); // .NET Core でShift-JISを扱うためのおまじない
            Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
            _width = sjisEnc.GetByteCount(str);
        }

        public override void Open()
        {
            PrintLine();
        }

        public override void Print()
        {
            Console.WriteLine($"|{_str}|");
        }

        public override void Close()
        {
            PrintLine();
        }

        private void PrintLine()
        {
            Console.Write("+");
            for (int i = 0; i < _width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }

    }
}
