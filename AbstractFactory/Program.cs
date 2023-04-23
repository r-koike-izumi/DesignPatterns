// AbstractFactory 関連する部品を組み合わせて製品を作る

using AbstractFactory_Factory;

namespace AbstractFactory
{
    class Program
    {
        public static void Main(string[] args)
        {
            Factory factory = null;

            Console.WriteLine("Example 1: ListFactory.ListFactory");
            Console.WriteLine("Example 2: TableFactory.TableFactory");
            Console.Write("Select No.:");
            var no = Console.ReadLine();
            if (no == "1")
            {
                 factory = Factory.GetFactory("AbstractFactory_ListFactory.ListFactory");
            }
            else
            {
                 factory = Factory.GetFactory("AbstractFactory_TableFactory.TableFactory");
            }

            Link asahi = factory.CreateLink("朝日新聞", "https://www.asahi.com/");
            Link yomiuri = factory.CreateLink("読売新聞", "https://www.yomiuri.co.jp/");

            Link us_yahoo = factory.CreateLink("Yahoo!", "https://www.yahoo.com/");
            Link jp_yahoo = factory.CreateLink("Yahoo!Japan", "https://www.yahoo.co.jp");
            Link excite = factory.CreateLink("Excite", "https://www.excite.com");
            Link google = factory.CreateLink("Google", "https://www.google.com/");

            Tray trayNews = factory.CreateTray("新聞");
            trayNews.Add(asahi);
            trayNews.Add(yomiuri);

            Tray trayYahoo = factory.CreateTray("Yahoo!");
            trayYahoo.Add(us_yahoo);
            trayYahoo.Add(jp_yahoo);

            Tray traySearch = factory.CreateTray("サーチエンジン");
            traySearch.Add(trayYahoo);
            traySearch.Add(excite);
            traySearch.Add(google);

            Page page = factory.CreatePage("LinkPage", "r.koike");
            page.Add(trayNews);
            page.Add(traySearch);
            page.Output();

            Console.WriteLine("");
            Console.WriteLine("Enterキーを押すと終了します。");
            Console.ReadLine();
        }
    }

}
