using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using AbstractFactory_Factory;

namespace AbstractFactory_ListFactory
{
    public class ListPage : Page
    {
        public ListPage(string title, string author) : base(title, author) { }

        public override string MakeHTML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"<html><head><title>{Title}</title></head>\n");
            sb.Append("<body>\n");
            sb.Append($"<h1>{Title}</h1>\n");
            sb.Append("<ul>\n");
            IEnumerator<Item> e = Content.GetEnumerator();
            while (e.MoveNext())
            {
                sb.Append(e.Current.MakeHTML());
            }
            sb.Append("</ul>\n");
            sb.Append($"<hr><address>{Author}</address>");
            sb.Append("</body></html>\n");
            
            return sb.ToString();
        }
    }
}
