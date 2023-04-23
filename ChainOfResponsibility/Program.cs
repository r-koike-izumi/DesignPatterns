
// ChainOfResponsibility 責任のたらい回し

namespace ChainOfResponsibility
{
    class Program
    {
        public static void Main(string[] args)
        {
            Support goldship = new NoSupport("ゴールドシップ");
            Support mejiromcqueen = new LimitSupport("メジロマックイーン", 100);
            Support specialweek = new SpecialSupport("スペシャルウィーク", 429);
            Support silencesuzuka = new LimitSupport("サイレンススズカ", 200);
            Support daiwascarlet = new OddSupport("ダイワスカーレット");
            Support vodka = new LimitSupport("ウォッカ", 300);

            // 連鎖の形成
            goldship.SetNext(mejiromcqueen).SetNext(specialweek).SetNext(silencesuzuka).SetNext(daiwascarlet).SetNext(vodka);

            for(int i = 0; i < 500; i+=33)
            {
                goldship.DoSupport(new Trouble(i));
            }

            Console.WriteLine("");
            Console.WriteLine("Enterキーを押すと終了します。");
            Console.ReadLine();
        }
    }
}
