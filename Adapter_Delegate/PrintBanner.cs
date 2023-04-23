using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Delegate
{
    public class PrintBanner : Print
    {
        private Banner _banner;

        public PrintBanner(string str)
        {
            _banner = new Banner(str);
        }

        public override void PrintWeak()
        {
            _banner.ShowWithParen();
        }

        public override void PrintStrong()
        {
            _banner.ShowWithAster();
        }
    }
}
