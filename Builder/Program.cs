
// Builder 複雑なインスタンスを組み立てる

using System.Text;

namespace Builder
{
    class Program
    {
        public static void Main(string[] args)
        {
            TextBuilder textBuilder = new TextBuilder();
            Director director1 = new Director(textBuilder);
            director1.Construct();
            string text = textBuilder.Text;
            Console.WriteLine(text);

            HTMLBuilder htmlBuilder = new HTMLBuilder();
            Director director2 = new Director(htmlBuilder);
            director2.Construct();
            string fileName = htmlBuilder.FileName;
            Console.WriteLine(fileName);

            // ファイルの中身を表示
            var lines = File.ReadLines(fileName);
            {
                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Enterキーを押すと終了します。");
            Console.ReadLine();
        }
    }
}
