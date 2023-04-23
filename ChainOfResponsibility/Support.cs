using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public abstract class Support
    {
        private string _name;
        private Support _next;

        public Support(string name)
        {
            _name = name;
        }

        public Support SetNext(Support next)
        {
            _next = next;
            return next;
        }

        public void DoSupport(Trouble trouble)
        {
            if (Resolve(trouble))
            {
                Done(trouble);
            }
            else if (_next != null)
            {
                _next.DoSupport(trouble);
            }
            else
            {
                Fail(trouble);
            }
        }

        public override string ToString()
        {
            return $"[{_name}]";
        }

        protected abstract bool Resolve(Trouble trouble);

        protected void Done(Trouble trouble)
        {
            Console.WriteLine($"{trouble} is resolved by {this.ToString()}.");
        }

        protected void Fail(Trouble trouble)
        {
            Console.WriteLine($"{trouble.ToString()} cannot be resolved.");
        }
    }
}
