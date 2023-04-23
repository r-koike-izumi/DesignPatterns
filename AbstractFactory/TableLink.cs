using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AbstractFactory_Factory;

namespace AbstractFactory_TableFactory
{
    public class TableLink : Link
    {
        public TableLink(string caption, string url) : base(caption, url) { }

        public override string MakeHTML()
        {
            return $"<td><a href=\"{ Url}\">" + Caption + "</a></td>\n"; 
        }
    }
}
