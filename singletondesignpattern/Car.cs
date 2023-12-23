namespace SingletonDesignPattern
{
    public sealed class Car
    {
        private static readonly Lazy<Car> carInstance = new Lazy<Car>(() => new Car());

        //Private Constructor
        private Car()
        {
            Console.WriteLine("Car object is created");
        }

        public static Car Instance => carInstance.Value;

        public void GetCarBrand()
        {
            Console.WriteLine("Brand : Maruti");
        }
    }
}