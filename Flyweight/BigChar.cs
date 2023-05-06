using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class BigChar
    {
        private string _fontdata;

        public BigChar(char charname)
        {
            try
            {
                using (var sr = new StreamReader(@$"..\..\..\data\big{charname}.txt"))
                {
                    StringBuilder sb = new StringBuilder();
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        sb.AppendLine(line);
                    }
                    _fontdata = sb.ToString();
                }
            }
            catch (System.IO.IOException)
            {
                _fontdata = charname + "?";
            }
        }

        public void Print()
        {
            Console.WriteLine(_fontdata);
        }
    }
}
