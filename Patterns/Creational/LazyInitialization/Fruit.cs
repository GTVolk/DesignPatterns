using System;
using System.Collections.Generic;

namespace DesiginPatterns.Patterns.Creational.LazyInitialization
{
    public class Fruit
    {
        private readonly string _typeName;
        private static readonly IDictionary<string, Fruit> _typesDictionary = new Dictionary<string, Fruit>();

        private Fruit(String typeName)
        {
            this._typeName = typeName;
        }

        public string GetTypeName()
        {
            return _typeName;
        }

        public static Fruit GetFruitByTypeName(string type)
        {
            if (!_typesDictionary.TryGetValue(type, out Fruit fruit))
            {
                // Lazy initialization
                fruit = new Fruit(type);

                _typesDictionary.Add(type, fruit);
            }
            return fruit;
        }

        public static void ShowAll()
        {
            if (_typesDictionary.Count > 0)
            {
                Console.WriteLine("Number of instances made = {0}", _typesDictionary.Count);

                foreach (KeyValuePair<string, Fruit> kvp in _typesDictionary)
                {
                    Console.WriteLine(kvp.Key);
                }

                Console.WriteLine();
            }
        }

        public Fruit()
        {
            // required so the sample compiles
        }
    }
}
