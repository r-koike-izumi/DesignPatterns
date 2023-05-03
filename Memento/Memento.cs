using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoGame
{
    public class Memento
    {
        private List<string> _fruits = new List<string>();

        public int Money { get; private set; }

        public Memento(int money)
        {
            this.Money = money;
        }

        public void AddFruit(string fruit)
        {
            _fruits.Add(fruit);
        }

        public List<string> GetFruits()
        {
            // 複製して返す
            return new List<string>(_fruits);
        }
    }
}
