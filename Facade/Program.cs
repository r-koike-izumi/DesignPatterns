
// Facade シンプルな窓口

using System;

namespace Facade
{
    class Program
    {
        public static void Main(string[] args)
        {
            PageMaker.MakeWelcomePage("silencesuzuka@ura.com", "welcome.html");

            Console.WriteLine("");
            Console.WriteLine("Enterキーを押すと終了します。");
            Console.ReadLine();
        }
    }
}
