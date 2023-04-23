using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ProbStrategy : IStrategy
    {
        private Random _random;
        private int _prevHandvalue = 0;
        private int _currentHandvalue = 0;

        private int[][] _history =
        {
            new int[] {1, 1, 1,},
            new int[] {1, 1, 1,},
            new int[] {1, 1, 1,},
        };

        public ProbStrategy(int seed)
        {
            _random = new Random(seed);
        }

        public Hand NextHand()
        {
            int bet = _random.Next(GetSum(_currentHandvalue));
            int handvalue = 0;
            if (bet < _history[_currentHandvalue][0])
            {
                handvalue = 0;
            }
            else if (bet < _history[_currentHandvalue][0] + _history[_currentHandvalue][1]) {
                handvalue = 1;
            }
            else
            {
                handvalue = 2;
            }
            _prevHandvalue = _currentHandvalue;
            _currentHandvalue = handvalue;
            return Hand.GetHand(handvalue);
        }

        private int GetSum(int hv)
        {
            int sum = 0;
            for(int i = 0; i < 3; i++)
            {
                sum += _history[hv][i];
            }
            return sum;
        }

        public void Study(bool win)
        {
            if (win)
            {
                _history[_prevHandvalue][_currentHandvalue]++;
            }
            else
            {
                _history[_prevHandvalue][(_currentHandvalue + 1) % 3]++;
                _history[_prevHandvalue][(_currentHandvalue + 2) % 3]++;
            }
        }
    }
}
