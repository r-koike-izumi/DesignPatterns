
// Singleton たった1つのインスタンス

namespace Singleton
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Start.");
            
            Singleton obj1 = Singleton.Instance;
            Singleton obj2 = Singleton.Instance;

            if (obj1 == obj2)
            {
                Console.WriteLine("obj1とobj2は同じインスタンスです。");
            }
            else
            {
                Console.WriteLine("obj1とobj2は同じインスタンスではありません。");
            }

            Console.WriteLine("End.");

            Console.WriteLine("");
            Console.WriteLine("Enterキーを押すと終了します。");
            Console.ReadLine();
        }
    }
}