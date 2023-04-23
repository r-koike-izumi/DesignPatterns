using Prototype_Framework;
using System.Text;

namespace Prototype
{
    public class MessageBox : IProduct
    {
        private char _decochar;

        public MessageBox(char decochar)
        {
            _decochar = decochar;
        }

        public void Use(string s)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); // .NET Core でShift-JISを扱うためのおまじない
            Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
            int length = sjisEnc.GetByteCount(s);
            for(int i = 0; i < length + 4; i++)
            {
                Console.Write(_decochar);
            }
            Console.WriteLine("");
            Console.WriteLine($"{_decochar} {s} {_decochar}");
            for (int i = 0; i < length + 4; i++)
            {
                Console.Write(_decochar);
            }
            Console.WriteLine("");
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public IProduct CreateClone()
        {
            return (IProduct)Clone();
        }
    }
}
