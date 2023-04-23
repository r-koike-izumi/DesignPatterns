using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ColleagueTextBox : TextBox, IColleague
    {
        private IMediator _mediator;

        public ColleagueTextBox(string text)
        {
            this.Text = text;
            this.TextChanged += new EventHandler(ColleagueChanged);
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void SetColleagueEnabled(bool enabled)
        {
            this.Enabled = enabled;
            this.BackColor = enabled ? Color.White : Color.LightGray;
        }

        public new void ColleagueChanged(object sender, EventArgs e)
        {
            _mediator.ColleagueChanged(); 
        }
    }
}
