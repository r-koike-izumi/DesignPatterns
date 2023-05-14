using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Printer : IPrintable
    {
        public Printer()
        {
            HeavyJob("Printerのインスタンスを生成中");
        }

        public Printer(string name)
        {
            this.PrinterName = name;
            HeavyJob($"Printerのインスタンス({this.PrinterName})を生成中");
        }

        public string PrinterName { get; set; }

        public void Print(string str)
        {
            Console.WriteLine($"=== {this.PrinterName} ===");
            Console.WriteLine(str);
        }

        private void HeavyJob(string msg)
        {
            Console.Write(msg);
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }
            Console.WriteLine("完了。");
        }
    }
}
