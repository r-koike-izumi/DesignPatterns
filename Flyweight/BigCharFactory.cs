using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class BigCharFactory
    {
        private Dictionary<char, BigChar> _pool = new Dictionary<char, BigChar>();

        // Singletonパターン 唯一のインスタンスを得る
        public static BigCharFactory Instance { get; } = new BigCharFactory();

        private BigCharFactory() { }

        public BigChar GetBigChar(char charname)
        {
            lock (this)
            {
                BigChar bc = null;
                if (_pool.ContainsKey(charname))
                {
                    // 生成済みならば、poolにあるインスタンスを返す
                    bc = _pool[charname];
                }
                else
                {
                    // ここでBigCharのインスタンスを生成
                    bc = new BigChar(charname);
                    _pool[charname] = bc;
                }
                return bc;
            }
        }
    }
}
