using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ListVisitor : Visitor
    {
        private string _currentDir = "";

        public override void Visit(File file)
        {
            Console.WriteLine($"{_currentDir}/{file.ToString()}");
        }

        public override void Visit(Directory directory)
        {
            Console.WriteLine($"{_currentDir}/{directory.ToString()}");
            string saveDir = _currentDir;
            _currentDir = $"{_currentDir}/{directory.GetName()}";
            var it = directory.Iterator();
            while (it.MoveNext())
            {
                it.Current.Accept(this);
            }
            _currentDir = saveDir;
        }
    }
}
