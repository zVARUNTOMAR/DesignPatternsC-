namespace FactoryDesignPatter
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee employee = EmployeeFactory.GetEmployee("ANDROIDDEV");
            Console.WriteLine($"ANDROID DEV SALARY : {employee.GetSalary()}");

            IEmployee employee2 = EmployeeFactory.GetEmployee("WEBDEVELOPER");
            Console.WriteLine($"WEB DEV SALARY : {employee2.GetSalary()}");

        }
    }
}