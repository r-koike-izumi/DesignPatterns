
// Strategy アルゴリズムをごっそり切り替える

namespace Strategy
{
    class Program
    {
        public static void Main(string[] args)
        {
            var random = new Random();
            int seed1 = random.Next();
            int seed2 = random.Next();

            Player player1 = new Player("スペシャルウイーク", new WinningStrategy(seed1));
            Player player2 = new Player("サイレンススズカ", new ProbStrategy(seed2));

            for(int i = 0; i < 10000; i++)
            {
                Hand nextHand1 = player1.NextHand();
                Hand nextHand2 = player2.NextHand();
                if (nextHand1.IsStrongerThan(nextHand2))
                {
                    Console.WriteLine("Winner:" + player1.ToString());
                    player1.Win();
                    player2.Lose();
                }
                else if (nextHand2.IsStrongerThan(nextHand1))
                {
                    Console.WriteLine("Winner:" + player2.ToString());
                    player1.Lose();
                    player2.Win();
                }
                else
                {
                    Console.WriteLine("Even...");
                    player1.Even();
                    player2.Even();
                }
            }

            Console.WriteLine("Total result:");
            Console.WriteLine(player1.ToString());
            Console.WriteLine(player2.ToString());

            Console.WriteLine("");
            Console.WriteLine("Enterキーを押すと終了します。");
            Console.ReadLine();
        }
    }
}