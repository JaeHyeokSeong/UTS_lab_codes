namespace week10_lab_codes
{
    public class MathOperation
    {
        public static void Addition(double v1, double v2)
        {
            Console.WriteLine("{0} + {1} = {2}", v1, v2, v1+v2);
        }
        public static void Subtraction(double v1, double v2)
        {
            Console.WriteLine("{0} - {1} = {2}", v1, v2, v1 - v2);
        }
        public static void Multiplication(double v1, double v2)
        {
            Console.WriteLine("{0} X {1} = {2}", v1, v2, v1 * v2);
        }
        public static void Division(double v1, double v2)
        {
            Console.WriteLine("{0} / {1} = {2}", v1, v2, v1 / v2);
        }
        public static void Modulus(double v1, double v2)
        {
            Console.WriteLine("{0} % {1} = {2}", v1, v2, v1 % v2);
        }
    }
    public class Program
    {
        delegate void MyDelegate(double v1, double v2);
        public static void Main(string[] args)
        {
            MyDelegate run = new MyDelegate(MathOperation.Addition);
            run += MathOperation.Subtraction;
            run += MathOperation.Multiplication;
            run += MathOperation.Division;
            run += MathOperation.Modulus;

            Console.WriteLine("Executing the Multicast Delegate: ");
            run(5, 4);

            run -= MathOperation.Subtraction;
            run -= MathOperation.Modulus;
            Console.WriteLine("\ncExecuting the Multicast Delegate after removing some operations");
            run(5, 4);

        }
    }
}