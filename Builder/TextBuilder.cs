using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class TextBuilder: Builder
    {
        private StringBuilder _sb = new StringBuilder();

        public string Text
        {
            get { return _sb.ToString(); }
        }

        public override void MakeTitle(string title)
        {
            _sb.AppendLine("================");
            _sb.AppendLine("『" + title+ "』");
            _sb.AppendLine("");
        }

        public override void MakeString(string str)
        {
            _sb.AppendLine("■" + str);
            _sb.AppendLine("");
        }

        public override void MakeItems(List<string> items)
        {
            foreach (string item in items)
            {
                _sb.AppendLine(item);
            }
            _sb.AppendLine("");
        }

        public override void Close()
        {
            _sb.AppendLine("================");
        }
    }
}
