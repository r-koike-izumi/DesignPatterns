using FactoryMethod_Framework;

namespace FactoryMethod_IDCard
{
    public class IDCardFactory : Factory
    {
        public List<string> Owners { get; private set; } = new List<string>();

        protected override Product CreateProduct(string owner)
        {
            return new IDCard(owner);
        }

        protected override void RegisterProduct(Product product)
        {
            Owners.Add(((IDCard)product).Owner);
        }
    }
}
