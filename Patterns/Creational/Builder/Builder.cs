namespace DesiginPatterns.Patterns.Creational.Builder
{
    // "Builder"
    abstract class Builder
    {
        public virtual void BuildPartA() { }
        public virtual void BuildPartB() { }
        public abstract Product GetResult();
    }
}
