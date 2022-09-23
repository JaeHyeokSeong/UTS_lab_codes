using System;
namespace Program1
{
    public class EmployeeList
    {
        List<Employee> employees = null;
        public EmployeeList()
        {
            employees = new List<Employee>();
        }
        public void LoadEmployees(string fileName)
        {
            string[] employeeInfo;
            string? content = "";
            FileStream fs; StreamReader sr = null;
            try
            {
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                do
                {
                    content = sr.ReadLine();
                    if(content != null)
                    {
                        employeeInfo = content.Split(",");
                        for(int i = 0; i < employeeInfo.Length; i++)
                        {
                            employeeInfo[i] = employeeInfo[i].Trim();
                        }
                        try
                        {
                            string firstName = employeeInfo[0];
                            string lastName = employeeInfo[1];
                            double hourlyRate = Convert.ToDouble(employeeInfo[2]), workHours = Convert.ToDouble(employeeInfo[4]);
                            int employeeID = Convert.ToInt32(employeeInfo[3]);
                            employees.Add(new Employee(firstName, lastName, hourlyRate, workHours, employeeID));
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Something is wrong");
                        }
                    }

                } while (content != null);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
        public void PrintEmployees()
        {
            foreach(Employee employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
        public void SortEmPloyees()
        {
            try
            {
                employees.Sort();
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

