using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AbstractFactory_Factory;

namespace AbstractFactory_TableFactory
{
    public class TableTray : Tray
    {
        public TableTray(string caption) : base(caption) { }

        public override string MakeHTML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<td>");
            sb.Append("<table width=\"100%\" border=\"1\"><tr>");
            sb.Append($"<td bgcolor=\"#cccccc\" align=\"center\" colspan=\"{Trays.Count()}\"><b>{Caption}</b></td>");
            sb.Append("</tr>\n");
            sb.Append("<tr>\n");
            IEnumerator<Item> e = Trays.GetEnumerator();
            while (e.MoveNext())
            {
                sb.Append(e.Current.MakeHTML());
            }
            sb.Append("</tr></table>");
            sb.Append("</td>");
            return sb.ToString();
        }
    }
}
