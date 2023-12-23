namespace PrototypeDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            IShape circlePrototype = new Circle { Radius = 5 };

            // Clone the prototype to create new objects
            IShape circle1 = circlePrototype.Clone();
            IShape circle2 = circlePrototype.Clone();

            // Modify cloned objects
            ((Circle)circle1).Radius = 10;
            ((Circle)circle2).Radius = 15;

            // Draw shapes
            circle1.Draw(); // Drawing a circle with radius 10
            circle2.Draw(); // Drawing a c
        }
    }
}