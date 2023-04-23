using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class SpecialSupport : Support
    {
        private int _number;

        public SpecialSupport(string  name, int number) : base(name)
        {
            _number = number;
        }

        protected override bool Resolve(Trouble trouble)
        {
            return (trouble.GetNumber() == _number);
        }
    }
}
