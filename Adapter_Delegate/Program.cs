
// Adapter 一皮かぶせて再利用(委譲)

namespace Adapter_Delegate
{
    class Program
    {
        public static void Main(string[] args)
        {
            Print p = new PrintBanner("Hello");
            p.PrintWeak();
            p.PrintStrong();

            Console.WriteLine("");
            Console.WriteLine("Enterキーを押すと終了します。");
            Console.ReadLine();
        }
    }
}