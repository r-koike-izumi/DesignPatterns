
// Adapter 一皮かぶせて再利用(継承)

namespace AdapterInheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            IPrint p = new PrintBanner("Hello");
            p.PrintWeak();
            p.PrintStrong();

            Console.WriteLine("");
            Console.WriteLine("Enterキーを押すと終了します。");
            Console.ReadLine();
        }
    }
}