using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MementoGame
{
    public class Gamer
    {
        private List<string> _fruits = new List<string>();
        private Random _random = new Random();
        private static string[] s_fruitsname = { "リンゴ", "ブドウ", "バナナ", "みかん" };

        public int Money { get; private set; }

        public Gamer(int money)
        {
            this.Money = money;
        }

        public void Bet()
        {
            int dice = _random.Next(6) + 1;
            if (dice == 1)
            {
                this.Money += 100;
                Console.WriteLine("所持金が増えました。");
            }
            else if (dice == 2)
            {
                this.Money /= 2;
                Console.WriteLine("所持金が半分になりました。");
            }
            else if (dice == 6)
            {
                string f = GetFruit();
                Console.WriteLine($"フルーツ{f}をもらいました。");
                _fruits.Add(f);
            }
            else
            {
                Console.WriteLine("なにも起こりませんでした。");
            }
        }

        public Memento CreateMemento()
        {
            Memento m = new Memento(this.Money);
            IEnumerator<string> e = _fruits.GetEnumerator();
            while (e.MoveNext())
            {
                if (e.Current.StartsWith("おいしい"))
                {
                    m.AddFruit(e.Current);
                }
            }
            return m;
        }

        public void RestoreMemento(Memento memento)
        {
            this.Money = memento.Money;
            _fruits = memento.GetFruits();
        }

        public override string ToString()
        {
            string s = string.Join(", ", _fruits.ToArray());
            return $"[money = {this.Money}, fruits = {s}]";
        }

        private string GetFruit()
        {
            string prefix = "";
            if (_random.Next(0, 2) == 0)
            {
                prefix = "おいしい";
            }
            return prefix + s_fruitsname[_random.Next(s_fruitsname.Length)];
        }
    }
}
