namespace Problam1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int numper1 = int.Parse(Console.ReadLine());



            Console.Write("Enter second number: ");
            int numper2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nSum: {Class1.Calculate(numper1, numper2)}");       
            Console.WriteLine($"Difference: {Class1.Calculate(numper1, numper2, "-")}");
            Console.WriteLine($"Product: {Class1.Calculate(numper1, numper2, "*")}");
        }
    }
}
