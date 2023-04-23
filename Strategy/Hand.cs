using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Hand
    {
        public static readonly int HANDVALUE_GUU = 0;
        public static readonly int HANDVALUE_CHO = 1;
        public static readonly int HANDVALUE_PAA = 2;
        
        public static Hand[] hands =
        {
            new Hand(HANDVALUE_GUU),
            new Hand(HANDVALUE_CHO),
            new Hand(HANDVALUE_PAA)
        };

        private static readonly string[] handNames =
        {
            "グー",
            "チョキ",
            "パー"
        };

        private int _handvalue;

        private Hand(int handvalue)
        {
            _handvalue = handvalue;
        }

        public static Hand GetHand(int handvalue)
        {
            return hands[handvalue];
        }

        public bool IsStrongerThan(Hand h)
        {
            return Fight(h) == 1; 
        }

        public bool IsWeakerThan(Hand h)
        {
            return Fight(h) == -1;
        }

        private int Fight(Hand h)
        {
            if(this == h)
            {
                return 0;
            }
            else if((_handvalue + 1) % 3 == h._handvalue)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return handNames[_handvalue];
        }
    }
}
