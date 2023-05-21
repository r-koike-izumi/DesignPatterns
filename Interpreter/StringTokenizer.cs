using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class StringTokenizer
    {
        private string[] _strs;
        private int _index = -1;

        public StringTokenizer(string text)
        {
            this._strs = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        public string NextToken()
        {
            return _strs[++_index];
        }

        public string CurrentToken()
        {
            return _strs[_index];
        }

        public bool HasMoreTokens()
        {
            return (_index + 1) < _strs.Length;
        }
    }
}
