using Authlete.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Database
    {
        private Database() { }

        public static IDictionary<string, string> GetProperties(string dbname)
        {
            string filename = $"{dbname}.txt";
            IDictionary<string, string> prop;

            using(var reader = new StreamReader(filename))
            {
                // NuGet パッケージ「Authlete.Authlete」に含まれる PropertiesLoader クラスは Properties ファイルの仕様を解釈することができる。
                // これにより、キーバリュー形式のテキストファイルを読み込むことができる。
                prop = PropertiesLoader.Load(reader);
            }
            return prop;
        }
    }
}
