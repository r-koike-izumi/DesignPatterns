using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ColleagueRadioButton : RadioButton, IColleague
    {
        private IMediator _mediator;

        public ColleagueRadioButton(string text)
        {
            this.Text = text;
            this.CheckedChanged += new EventHandler(ColleagueChanged);
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void SetColleagueEnabled(bool enabled)
        {
            this.Enabled = enabled;
        }

        public void ColleagueChanged(object sender, EventArgs e)
        {
            _mediator.ColleagueChanged();
        }
    }
}
