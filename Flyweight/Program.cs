
// Flyweight 同じものを共有して無駄をなくす

namespace Flyweight
{
    class Program
    {
        public static void Main(string[] args)
        {
            string numStr = "1212123";

            var bs = new BigString(numStr);
            bs.Print();

            Console.WriteLine("");
            Console.WriteLine("Enterキーを押すと終了します。");
            Console.ReadLine();
        }
    }
}