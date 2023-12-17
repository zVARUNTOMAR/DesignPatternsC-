public class AndroidDevFactory : EmployeeAbstractFactory
{
    public IEmployee CreateEmployee()
    {
        return new AndroidDev();
    }
}