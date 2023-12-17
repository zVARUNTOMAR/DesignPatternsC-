public class WebDevFactory : EmployeeAbstractFactory
{
    public IEmployee CreateEmployee()
    {
        return new WebDev();
    }
}