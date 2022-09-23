namespace Program1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployeeList employeeList = new EmployeeList();
            employeeList.LoadEmployees("emp.txt");
            employeeList.PrintEmployees();

            employeeList.SortEmPloyees();
            Console.WriteLine("\nAfter Sorting");
            employeeList.PrintEmployees();
        }
    }
}