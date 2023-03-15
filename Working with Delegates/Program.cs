namespace Assignment8ex2
{
    public class MathSolutions
    {
        public delegate double calculate(double x, double y);
        public double GetSum(double x, double y)
        {
            return x + y;
        }
        public double GetProduct(double a, double b)
        {
            return a * b;
        }
        public void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }
        static void Main(string[] args)
        {
            // create a class object
            MathSolutions answer = new MathSolutions();
            //Creating a function delegate that references GetSum. Then I changed the method in the console.writeline
            Func<double, double, double> calculateSum = answer.GetSum;
            //Creating an action delegate that references GetSmaller. Then I changed the method.
            Action<double, double> calculatesmaller = answer.GetSmaller;
            //Creating a custom delegate and changing the method in the console.writeline
            calculate calculateProduct = new calculate(answer.GetProduct);

            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);
            Console.WriteLine($" {num1} + {num2} = {calculateSum(num1, num2)}");
            Console.WriteLine($" {num1} * {num2} = {calculateProduct(num1, num2)}");
            calculatesmaller(num1, num2);
        }
    }
}