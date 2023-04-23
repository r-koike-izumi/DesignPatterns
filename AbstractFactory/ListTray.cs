using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AbstractFactory_Factory;

namespace AbstractFactory_ListFactory
{
    public class ListTray : Tray
    {
        public ListTray(string caption) : base(caption) { }

        public override string MakeHTML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<li>\n");
            sb.Append($"{Caption}\n");
            sb.Append("<ul>\n");
            IEnumerator<Item> e = Trays.GetEnumerator();
            while (e.MoveNext())
            {
                sb.Append(e.Current.MakeHTML());
            }
            sb.Append("</ul>\n");
            sb.Append("</li>\n");

            return sb.ToString();
        }
    }
}
