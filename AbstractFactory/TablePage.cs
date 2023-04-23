using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AbstractFactory_Factory;

namespace AbstractFactory_TableFactory
{
    public class TablePage : Page
    {
        public TablePage(string title, string author) : base(title, author) { }

        public override string MakeHTML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"<html><head><title>{Title}</title></head>\n");
            sb.Append("<body>\n");
            sb.Append($"<h1>{Title}</h1>\n");
            sb.Append("<table width=\"80%\" border=\"3\">\n");
            IEnumerator<Item> e = Content.GetEnumerator();
            while (e.MoveNext())
            {
                sb.Append($"<tr>{e.Current.MakeHTML()}</true>");
            }
            sb.Append("</table>");
            sb.Append($"<hr><address>{Author}</address>");
            sb.Append("</body></html>\n");
            return sb.ToString();
        }
    }
}
