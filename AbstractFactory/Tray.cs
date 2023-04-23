using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Factory
{
    public abstract class Tray : Item
    {
        protected List<Item> Trays = new List<Item>(); 

        public Tray(string caption) : base(caption) { }

        public void Add(Item item)
        {
            Trays.Add(item);
        }
    }
}
