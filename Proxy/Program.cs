
// Proxy 必要になってから作る

namespace Proxy
{
    class Program
    {
        public static void Main(string[] args)
        {
            IPrintable p = new PrinterProxy("トーカイテイオー");
            Console.WriteLine($"名前は現在{p.PrinterName}です。");
            p.PrinterName = "メジロマックイーン";
            Console.WriteLine($"名前は現在{p.PrinterName}です。");
            p.Print("Hello, world.");

            Console.WriteLine("");
            Console.WriteLine("Enterキーを押すと終了します。");
            Console.ReadLine();
        }
    }
}