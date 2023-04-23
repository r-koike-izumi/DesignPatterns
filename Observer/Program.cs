
// Observer 状態の変化を通知する

namespace Observer
{
    class Program
    {
        public static void Main(string[] args)
        {
            NumberGenerator generator = new RandomNumberGenerator();
            IObserver observer1 = new DigitObserver();
            IObserver observer2 = new GraphObserver();
            generator.AddObserver(observer1);
            generator.AddObserver(observer2);
            generator.Execute();

            Console.WriteLine("");
            Console.WriteLine("Enterキーを押すと終了します。");
            Console.ReadLine();
        }
    }
}