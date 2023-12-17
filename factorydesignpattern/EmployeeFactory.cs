public static class EmployeeFactory
{
    public static IEmployee? GetEmployee(string employeeType)
    {

        if (employeeType == "ANDROIDDEV")
        {
            return new AndroidDeveloper();
        }
        else
        {
            if (employeeType == "WEBDEVELOPER")
            {
                return new WebDeveloper();
            }
        }

        return null;
    }
}