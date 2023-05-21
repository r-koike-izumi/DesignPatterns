using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandCommand
{
    public class MacroCommand : ICommand
    {
        private Stack<ICommand> _commands = new Stack<ICommand>();

        public virtual void Execute()
        {
            var it = _commands.GetEnumerator();
            while (it.MoveNext())
            {
                it.Current.Execute();
            }
        }

        public virtual void Append(ICommand cmd)
        {
            if (cmd != this)
            {
                _commands.Push(cmd);
            }
        }

        public virtual void Undo()
        {
            if (_commands.Count > 0)
            {
                _commands.Pop();
            }
        }

        public virtual void Clear()
        {
            _commands.Clear();
        }
    }
}
