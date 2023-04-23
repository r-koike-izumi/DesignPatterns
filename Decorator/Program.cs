
// Decorator 飾り枠と中身の同一視

namespace Decorator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Display b1 = new StringDisplay("Hello, world.");
            Display b2 = new SideBorder(b1, '#');
            Display b3 = new FullBorder(b2);
            b1.Show();
            b2.Show();
            b3.Show();
            Display b4 = new SideBorder(
                            new FullBorder(
                                new FullBorder(
                                    new SideBorder(
                                        new FullBorder(
                                            new StringDisplay("こんにちは。")
                                        )
                                    ,'*')
                                )
                            )
                         ,'/');
            b4.Show();

            Console.WriteLine("");
            Console.WriteLine("Enterキーを押すと終了します。");
            Console.ReadLine();
        }
    }
}
