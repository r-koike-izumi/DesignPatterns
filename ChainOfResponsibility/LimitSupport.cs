using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class LimitSupport : Support
    {
        private int _limit;
        public LimitSupport(string name, int limit) : base(name)
        {
            _limit = limit;
        }

        protected override bool Resolve(Trouble trouble)
        {
           return (trouble.GetNumber() < _limit);
        }
    }
}
