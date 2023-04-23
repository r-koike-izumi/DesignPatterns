using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Factory
{
    public abstract class Page
    {
        protected string Title;
        protected string Author;
        protected List<Item> Content = new List<Item>();

        public abstract string MakeHTML();

        public Page(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void Add(Item item)
        {
            Content.Add(item);
        }

        public void Output()
        {
            string filename =  $"{Title}.html";
            using (StreamWriter writer = new StreamWriter(filename, append: false, Encoding.GetEncoding("utf-8")))
            {
                writer.Write(this.MakeHTML());
                writer.Close();
                Console.WriteLine($"{filename}を作成しました。");
            }
        }
    }
}
