
// Visitor 構造を渡り歩きながら仕事をする

namespace Visitor
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Making root entries...");
                Directory rootDir = new Directory("root");
                Directory binDir = new Directory("bin");
                Directory tmpDir = new Directory("tmp");
                Directory usrDir = new Directory("usr");
                rootDir.Add(binDir);
                rootDir.Add(tmpDir);
                rootDir.Add(usrDir);
                binDir.Add(new File("vi", 10000));
                binDir.Add(new File("latex", 20000));
                rootDir.Accept(new ListVisitor());

                Console.WriteLine("");
                Console.WriteLine("Making user entries...");
                Directory oguri = new Directory("オグリキャップ");
                Directory tama = new Directory("タマモクロス");
                Directory creek = new Directory("スーパークリーク");
                usrDir.Add(oguri);
                usrDir.Add(tama);
                usrDir.Add(creek);
                oguri.Add(new File("diary.html", 100));
                oguri.Add(new File("Composite.cs", 200));
                tama.Add(new File("memo.txt", 300));
                creek.Add(new File("game.doc", 400));
                creek.Add(new File("ura.eml", 500));
                rootDir.Accept(new ListVisitor());
            }
            catch (FileTreatmentException e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("");
            Console.WriteLine("Enterキーを押すと終了します。");
            Console.ReadLine();
        }
    }
}
