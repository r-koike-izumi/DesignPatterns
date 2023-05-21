using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class CommandListNode : Node
    {
        private List<Node> _list = new List<Node>();

        public override void Parse(Context context)
        {
            while (true)
            {
                if (context.CurrentToken() == null)
                {
                    throw new ParseException("Missing 'end'");
                }
                else if (context.CurrentToken().Equals("end"))
                {
                    context.SkipToken("end");
                    break;
                }
                else
                {
                    Node commandNode = new CommandNode();
                    commandNode.Parse(context);
                    _list.Add(commandNode);
                }
            }
        }

        public override string ToString()
        {
            return _list.ToString();
        }
    }
}
