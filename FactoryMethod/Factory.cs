using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Framework
{
    public abstract class Factory
    {
        protected abstract Product CreateProduct(string owner);
        protected abstract void RegisterProduct(Product product);
        public Product Create(string owner)
        {
            Product p = CreateProduct(owner);
            RegisterProduct(p);
            return p;
        }
    }
}
