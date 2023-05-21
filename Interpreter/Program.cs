
// 文法規則をクラスで表現する

namespace Interpreter
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (var sr = new StreamReader(@$"..\..\..\program.txt"))
            {
                while (!sr.EndOfStream)
                {
                    var text = sr.ReadLine();
                    Console.WriteLine($"text = '{text}'");
                    Node node = new ProgramNode();
                    node.Parse(new Context(text));
                    Console.WriteLine($"node = {node}");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Enterキーを押すと終了します。");
            Console.ReadLine();
        }
    }
}