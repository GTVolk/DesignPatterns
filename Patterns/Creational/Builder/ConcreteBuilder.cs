using System;
using System.Collections.Generic;
using System.Text;

namespace DesiginPatterns.Patterns.Creational.Builder
{
    // "ConcreteBuilder1"
    class ConcreteBuilderA : Builder
    {
        private readonly Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("PartA");
        }

        public override void BuildPartB()
        {
            product.Add("PartB");
        }

        public override Product GetResult()
        {
            return product;
        }
    }

    // "ConcreteBuilder2"
    class ConcreteBuilderB : Builder
    {
        private readonly Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("PartX");
        }

        public override void BuildPartB()
        {
            product.Add("PartY");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
