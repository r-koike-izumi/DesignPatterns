
// Memento 状態を保存する

using MementoGame;

namespace MementoMain
{
    class Program
    {
        public static void Main(string[] args)
        {
            Gamer gamer = new Gamer(100);  
            Memento memento = gamer.CreateMemento();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"==== {i}");
                Console.WriteLine($"現状:{gamer}");

                gamer.Bet();

                Console.WriteLine($"所持金は{gamer.Money}円になりました。");

                if (gamer.Money > memento.Money)
                {
                    Console.WriteLine("        (だいぶ増えたので、現在の状態を保存しておこう)");
                    memento = gamer.CreateMemento();
                }
                else if (gamer.Money < memento.Money / 2)
                {
                    Console.WriteLine("        (だいぶ減ったので、以前の状態に復帰しよう)");
                    gamer.RestoreMemento(memento);
                }
            
                Thread.Sleep(500);
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("Enterキーを押すと終了します。");
            Console.ReadLine();
        }
    }
}
