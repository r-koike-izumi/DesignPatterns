
// FactoryMethod インスタンス作成をサブクラスにまかせる

using FactoryMethodFramework;
using FactoryMethodIDCard;

namespace FactoryMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            Factory factry = new IDCardFactory();
            Product card1 = factry.Create("ナイスネイチャ");
            Product card2 = factry.Create("イクノディクタス");
            Product card3 = factry.Create("ツインターボ");
            Product card4 = factry.Create("マチカネタンホイザ");

            Console.WriteLine("");

            card1.Use();
            card2.Use();
            card3.Use();
            card4.Use();

            Console.WriteLine("");
            Console.WriteLine("Enterキーを押すと終了します。");
            Console.ReadLine();
        }
    }
}