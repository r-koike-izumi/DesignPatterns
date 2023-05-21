using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class PrimitiveCommandNode : Node
    {
        private string _name;

        public override void Parse(Context context)
        {
            _name = context.CurrentToken();
            context.SkipToken(_name);
            if (!_name.Equals("go") && !_name.Equals("right") && !_name.Equals("left"))
            {
                throw new ParseException($"{_name} is undefined");
            }
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
