using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Framework
{
    public class Manager
    {
        private Dictionary<string, IProduct> _showcase = new Dictionary<string, IProduct>();
        
        public void Register(string name, IProduct proto)
        {
            _showcase.Add(name, proto);
        }

        public IProduct Create(string protoname)
        {
            IProduct p = _showcase[protoname];
            return p.CreateClone();
        }
    }
}
