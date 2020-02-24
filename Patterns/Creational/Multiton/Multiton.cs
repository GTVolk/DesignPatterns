using System.Collections.Generic;

namespace DesiginPatterns.Patterns.Creational.Multiton
{
    public enum MultitonType
    {
        ZERO,
        ONE,
        TWO
    };

    public class Multiton
    {
        private static readonly Dictionary<MultitonType, Multiton> instances =
            new Dictionary<MultitonType, Multiton>();
        private readonly int number;

        private Multiton(int number)
        {
            this.number = number;
        }

        public static Multiton GetInstance(MultitonType type)
        {
            // lazy init (not thread safe as written)
            // Recommend using Double Check Locking if needing thread safety
            if (!Multiton.instances.ContainsKey(type))
            {
                Multiton.instances.Add(type, new Multiton((int)type));
            }
            return Multiton.instances[type];
        }

        public override string ToString()
        {
            return "My number is " + number.ToString();
        }
    }
}
