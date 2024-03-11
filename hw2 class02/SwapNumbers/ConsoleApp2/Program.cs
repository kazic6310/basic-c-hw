namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            
            Console.Write("Input the First Number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            
            Console.Write("Input the Second Number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;

            
            Console.WriteLine("After Swapping:");
            Console.WriteLine("First Number: " + firstNumber);
            Console.WriteLine("Second Number: " + secondNumber);

            
        }
    }
}
