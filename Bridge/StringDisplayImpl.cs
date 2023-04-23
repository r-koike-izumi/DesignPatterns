using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class StringDisplayImpl : DisplayImpl
    {
        private string _str;
        private int _width;

        public StringDisplayImpl(string str)
        {
            _str = str;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); // .NET Core でShift-JISを扱うためのおまじない
            Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
            _width = sjisEnc.GetByteCount(_str);
        }

        public override void RawOpen()
        {
            PrintLine();
        }

        public override void RawPrint()
        {
            Console.WriteLine($"|{_str}|");
        }

        public override void RawClose()
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
