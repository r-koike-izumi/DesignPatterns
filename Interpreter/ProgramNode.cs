using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class ProgramNode : Node
    {
        private Node _commandListNode;

        public override void Parse(Context context)
        {
            context.SkipToken("program");
            _commandListNode = new CommandListNode();
            _commandListNode.Parse(context);
        }

        public override string ToString()
        {
            return $"[program {_commandListNode}]";
        }
    }
}
