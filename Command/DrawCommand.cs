using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using ICommand = CommandCommand.ICommand;

namespace CommandDrawer
{
    public class DrawCommand : ICommand
    {
        protected IDrawable Drawable;
        private Point _position;

        public DrawCommand(IDrawable drawable, Point position)
        {
            Drawable = drawable;
            _position = position;
        }

        public void Execute()
        {
            Drawable.Draw(_position.X, _position.Y);
        }
    }
}
