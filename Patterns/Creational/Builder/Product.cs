using System;
using System.Collections.Generic;

namespace DesiginPatterns.Patterns.Creational.Builder
{
    // "Product"
    class Product
    {
        private readonly List<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\nProduct Parts -------");
            foreach (string part in parts)
                Console.WriteLine(part);
        }
    }
}
