using System;
namespace Program1
{
    public class Employee : IComparable<Employee>
    {
        private string firstName = "", lastName = "";
        private double hourlyRate = 0, workHours = 0;
        private int employeeID = 0;

        public string FirstName
        {
            get { return firstName; }
        }
        public int EmployeeID
        {
            get { return employeeID; }
        }

        public Employee(string firstName, string lastName, double hourlyRate, double workHours, int employeeID)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.hourlyRate = hourlyRate;
            this.workHours = workHours;
            this.employeeID = employeeID;
        }
        public double GetWeeklySal()
        {
            return hourlyRate * workHours;
        }
        public override string ToString()
        {
            return String.Format("Employee Details: {0} {1} ID#: {2} Weekly Income: {3:C3}", firstName, lastName, employeeID, GetWeeklySal());
        }
        public int CompareTo(Employee? other)
        {
            if(other == null)
            {
                throw new NotImplementedException();
            }
            return employeeID.CompareTo(other.EmployeeID);
        }
    }
}

