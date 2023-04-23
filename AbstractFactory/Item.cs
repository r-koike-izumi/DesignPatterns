using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Factory
{
    public abstract class Item
    {
        protected string Caption;

        public abstract string MakeHTML();

        public Item(string caption)
        {
            Caption = caption;
        }
    }
}
