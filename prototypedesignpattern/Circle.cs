namespace PrototypeDesignPattern
{
    public class Circle : IShape
    {
        public int Radius { get; set; }
        public IShape Clone()
        {
            return (IShape)MemberwiseClone();
        }
        public void Draw()
        {
            Console.WriteLine($"Drawing a circle with radius {Radius}");
        }
    }
}