using Prototype_Framework;
using System.Text;

namespace Prototype
{
    public class UnderlinePen : IProduct
    {
        private char _ulchar;
        
        public UnderlinePen(char ulchar)
        {
            _ulchar = ulchar;
        }

        public void Use(string s)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); // .NET Core でShift-JISを扱うためのおまじない
            Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
            int length = sjisEnc.GetByteCount(s);
            Console.WriteLine($"\"{s}\"");
            Console.Write(" ");
            for(int i = 0; i < length; i++)
            {
                Console.Write(_ulchar);
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
