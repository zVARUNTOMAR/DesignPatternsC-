namespace SingletonDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book book1 = Book.Instance;
            Book book2 = Book.Instance;

            Console.WriteLine($"Is instance1 the same as instance2? {ReferenceEquals(book1, book2)}");

            // Use singleton methods
            book1.GetBookTitle();
            book2.GetBookTitle();


            Car car1 = Car.Instance;
            Car car2 = Car.Instance;

            Console.WriteLine($"Is instance1 the same as instance2? {ReferenceEquals(car1, car2)}");

            // Use singleton methods
            car1.GetCarBrand();
            car2.GetCarBrand();
        }
    }
}