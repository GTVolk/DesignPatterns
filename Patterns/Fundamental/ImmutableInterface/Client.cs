using System;

namespace DesiginPatterns.Patterns.Fundamental.ImmutableInterface
{
    class Client
    {
        public void Run()
        {
            IImmutablePoint2D point = (IImmutablePoint2D)new Point2D(0, 0);  // a concrete instance of Point2D is referenced by the immutable interface
            Console.WriteLine("X = %d", point.GetX()); // valid method call
            // point.setX(42); // compile error: the method setX() does not exist on type ImmutablePoint2D
            ((Point2D)point).SetX(42); // this call is legal, since the type has
                                       // been converted to the mutable Point2D class
            Console.WriteLine("X = %d", point.GetX()); // valid method call
        }
    }
}
