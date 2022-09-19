namespace Program1
{
    public class MyGenericStack<T>
    {
        private int top = -1;
        private T[] stackElements;

        public int Length
        {
            get
            {
                return stackElements.Length;
            }
        }
        public int NoElements
        {
            get
            {
                // return current elements number in a stack
                return top + 1;
            }
        }
        public MyGenericStack(int stackSize)
        {
            stackElements = new T[stackSize];
        }
        public void Push(T value)
        {
            if(top >= stackElements.Length - 1)
            {
                throw new StackOverflowException("No space to push a new value");
            }
            stackElements[++top] = value;
        }
        public T Pop()
        {
            if(top == -1)
            {
                throw new StackOverflowException("No elements to pop up");
            }
            T value = stackElements[top--];
            return value;
        }
    }
    public class Program
    {
        private static double[] numbers = { 4.5, 9.2, 5.6, 3.4, 1.2, 0};
        private static string[] names = { "Martin", "Alex", "Alan", "George", "Paul"};
        public static void Main(string[] args)
        {
            Console.Clear();
            MyGenericStack<double> myGenericStack1 = new MyGenericStack<double>(6);
            MyGenericStack<string> myGenericStack2 = new MyGenericStack<string>(5);
            // push
            foreach(double value in numbers)
            {
                try
                {
                    myGenericStack1.Push(value);
                } catch(StackOverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine();
            foreach(string value in names)
            {
                try
                {
                    myGenericStack2.Push(value);
                } catch(StackOverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            // pop
            Console.WriteLine("\nThe Double Stack had the following values:");
            for (int i = 0; i < myGenericStack1.Length; i++)
            {
                try
                {
                    Console.Write("{0} {1} ", myGenericStack1.Pop(), (i == myGenericStack1.Length - 1) ? "" : "-->");
                } catch(StackOverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("\n\nThe String Stack had the following values:");
            for (int i = 0; i < myGenericStack2.Length; i++)
            {
                try
                {
                    Console.Write("{0} {1} ", myGenericStack2.Pop(), (i == myGenericStack2.Length - 1) ? "" : "-->");
                }
                catch (StackOverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}