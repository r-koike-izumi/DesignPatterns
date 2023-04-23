using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class HTMLBuilder : Builder
    {
        public string FileName { get; private set;}

        public override void MakeTitle(string title)
        {
            FileName = title + ".html";

            using (StreamWriter writer = new StreamWriter(FileName, append: false, Encoding.GetEncoding("utf-8")))
            {
                writer.WriteLine("<html>");
                writer.WriteLine("<head><title>" + title + "</title></head>");
                writer.WriteLine("<body>");
                writer.WriteLine("<H1>" + title + "</H1>");
            }
        }

        public override void MakeString(string str)
        {
            using (StreamWriter writer = new StreamWriter(FileName, append: true, Encoding.GetEncoding("utf-8")))
            {
                writer.WriteLine("<p>" + str + "</p>");
            }
        }

        public override void MakeItems(List<string> items)
        {
            using (StreamWriter writer = new StreamWriter(FileName, append: true, Encoding.GetEncoding("utf-8")))
            {
                writer.WriteLine("<ul>");
                foreach (string item in items)
                {
                    writer.WriteLine("<li>" + item + "</li>");
                }
                writer.WriteLine("</ul>");
            }
        }

        public override void Close()
        {
            using (StreamWriter writer = new StreamWriter(FileName, append: true, Encoding.GetEncoding("utf-8")))
            {
                writer.WriteLine("</body");
                writer.WriteLine("</html");
                writer.Close();
            }
        }
    }
}
