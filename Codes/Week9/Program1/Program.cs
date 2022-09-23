namespace Program1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
             * emp.txt contnets
             * 
             * Jetson, Jordon, 12.56, 1232, 20.0
               Cogswall, James, 22.45, 7165, 30.5
               Spacelly, George, 27.04,5903, 35.8
               Elroy, Alsison, 6.86,0123, 17.0
               Rosie, Philip, 9.93, 8080, 28.3
             */
            EmployeeList employeeList = new EmployeeList();
            employeeList.LoadEmployees("emp.txt");
            employeeList.PrintEmployees();

            employeeList.SortEmployeesByID();
            Console.WriteLine("\nAfter Sorting by using an ID");
            employeeList.PrintEmployees();

            employeeList.SortEmployeeByFirstName();
            Console.WriteLine("\nAfter Sorting by using an First Name");
            employeeList.PrintEmployees();
        }
    }
}