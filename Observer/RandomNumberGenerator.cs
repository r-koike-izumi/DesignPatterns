using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class RandomNumberGenerator : NumberGenerator
    {
        private Random _random = new Random();
        private int _number;

        public override int GetNumber()
        {
            return _number;
        }

        public override void Execute()
        {
            for(int  i = 0; i < 20; i++)
            {
                _number = _random.Next(50);
                NotifyObservers();
            }
        }
    }
}
