
// TemplateMethod 具体的な処理をサブクラスにまかせる

namespace TemplateMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            AbstractDisplay d1 = new CharDisplay('H');
            AbstractDisplay d2 = new StringDisplay("Hello, world.");
            AbstractDisplay d3 = new StringDisplay("こんにちは。");

            d1.Display();
            d2.Display();
            d3.Display();

            Console.WriteLine("");
            Console.WriteLine("Enterキーを押すと終了します。");
            Console.ReadLine();
        }
    }
}