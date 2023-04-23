using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AbstractFactory_Factory;

namespace AbstractFactory_ListFactory
{
    public class ListLink : Link
    {
        public ListLink(string caption, string url) : base(caption, url) { }

        public override string MakeHTML()
        {
            return $"    <li><a href=\"{ Url}\">{Caption}</a></li>\n";
        }

    }
}
