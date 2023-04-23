using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class HtmlWriter
    {
        private StreamWriter _writer;

        public HtmlWriter(StreamWriter writer)
        {
            _writer = writer;
        }

        public void Title(string title)
        {
            _writer.Write("<html>");
            _writer.Write("<head>");
            _writer.Write($"<title>{title}</title>");
            _writer.Write("</head>");
            _writer.Write("<body>\n");
            _writer.Write($"<h1>{title}</h1>\n");
        }

        public void Paragraph(string msg)
        {
            _writer.Write($"<p>{msg}</p>\n");
        }

        public void Link(string href, string caption)
        {
            Paragraph($"<a href={href}>{caption}</a>");
        }

        public void Mailto(string mailaddr, string username)
        {
            Link($"mailto:{mailaddr}", username);
        }

        public void Close()
        {
            _writer.Write("</body>");
            _writer.Write("</html>\n");
            _writer.Close();
        }
    }
}
