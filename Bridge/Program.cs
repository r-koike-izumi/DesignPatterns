
// Bridge 機能の階層と実装の階層を分ける

namespace Bridge
{
    class Program
    {
        public static void Main(string[] args)
        {
            Display d1 = new Display(new StringDisplayImpl("Hello, Japan."));
            Display d2 = new CountDisplay(new StringDisplayImpl("Hello, World."));
            CountDisplay d3 = new CountDisplay(new StringDisplayImpl("Hello, Universe."));

            d1.Show();
            d2.Show();
            d3.Show();
            d3.MultiDisplay(5);

            Console.WriteLine("");
            Console.WriteLine("Enterキーを押すと終了します。");
            Console.ReadLine();
        }
    }
}

