namespace AbstractDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee employee = EmployeeFactory.GetEmployee(new AndroidDevFactory());
            Console.WriteLine($"Salary : {employee.GetSalary()} Name : {employee.GetName()}");

            IEmployee employee2 = EmployeeFactory.GetEmployee(new WebDevFactory());
            Console.WriteLine($"Salary : {employee2.GetSalary()} Name : {employee2.GetName()}");

        }
    }
}