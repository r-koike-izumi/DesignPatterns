using FactoryMethodFramework;

namespace FactoryMethodIDCard
{
    public class IDCard : Product
    {
        public string Owner { get; private set; }

        public IDCard(string owner)
        {
            Console.WriteLine($"{owner}のカードを作ります。");
            this.Owner = owner;
        }

        public override void Use()
        {
            Console.WriteLine($"{this.Owner}カードを使います。");
        }
    }
}
