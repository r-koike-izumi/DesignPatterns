using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class DigitObserver : IObserver
    {
        public void Update(NumberGenerator generator)
        {
            Console.WriteLine($"DigitObserver: {generator.GetNumber()}");
            Thread.Sleep(100);
        }
    }
}
