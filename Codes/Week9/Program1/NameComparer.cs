using System;
namespace Program1
{
    public class NameComparer : IComparer<Employee>
    {
        public NameComparer()
        {
        }

        public int Compare(Employee? x, Employee? y)
        {
            if(x == null || y == null)
            {
                throw new NotImplementedException();
            }
            return x.FirstName.CompareTo(y.FirstName);
        }
    }
}

