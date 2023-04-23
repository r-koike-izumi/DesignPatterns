using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        public static Singleton Instance { get; private set; } = new Singleton();
        
        // コンストラクタは private
        private Singleton()
        {
            Console.WriteLine("インスタンスを生成しました。");
        }
    }
}
