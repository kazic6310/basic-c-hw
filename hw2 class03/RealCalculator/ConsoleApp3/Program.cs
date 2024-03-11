namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double result;

            Console.WriteLine("Enter the first number: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operation: ( + ) ( - ) ( * ) ( / )");

            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                        Console.WriteLine($"The result is: {result}");
                    break;
                 
                case "-":
                    result = num1 - num2;
                        Console.WriteLine($"The result is: {result}");
                    break;

                case "*":
                    result = num1 * num2;
                        Console.WriteLine($"The result is: {result}");
                    break;
                case "/":
                    result = num1 / num2;
                        Console.WriteLine($"The reult is: {result}");
                    break;
            }
        }
    }
}
