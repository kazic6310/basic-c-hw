namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter the first number: ");
            double input1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double input2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            double input3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fourth number: ");
            double input4 = double.Parse(Console.ReadLine());


            double sum = input1 + input2 + input3 + input4;

            Console.WriteLine($"The sum of all inputs is: {sum}");

            double result = sum / 4;

            Console.WriteLine($"The average of all inputs is: {result}");

        }
    }
}
