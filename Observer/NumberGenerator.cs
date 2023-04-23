using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public abstract class NumberGenerator
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void DeleteObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            var it = _observers.GetEnumerator();
            while (it.MoveNext())
            {
                it.Current.Update(this);
            }
        }

        public abstract int GetNumber();
        public abstract void Execute();
    }
}
