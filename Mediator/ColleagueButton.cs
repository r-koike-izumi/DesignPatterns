using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ColleagueButton : Button, IColleague
    {
        private IMediator _mediator;

        public ColleagueButton(string text)
        {
            this.Text = text;
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void SetColleagueEnabled(bool enabled)
        {
            this.Enabled = enabled;
        }
    }
}
