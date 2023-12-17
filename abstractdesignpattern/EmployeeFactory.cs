public static class EmployeeFactory
{
    public static IEmployee GetEmployee(EmployeeAbstractFactory abstractFactory)
    {
        return abstractFactory.CreateEmployee();
    }
}