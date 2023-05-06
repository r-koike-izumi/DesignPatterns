using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class BigString
    {
        private BigChar[] _bigchars;

        public BigString(string str)
        {
            _bigchars = new BigChar[str.Length];
            BigCharFactory factory = BigCharFactory.Instance;
            for (int i = 0; i < _bigchars.Length; i++)
            {
                _bigchars[i] = factory.GetBigChar(str[i]);
            }
        }

        public void Print()
        {
            for(int i = 0; i < _bigchars.Length; i++)
            {
                _bigchars[i].Print();
            }
        }
    }
}
