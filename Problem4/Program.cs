namespace Problem4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 11, 12, 13, 14, 15, 16, 17, 18, 19, 100 };
            int evenCount = 0;

            Class1.CountEvens(numbers, ref evenCount);
            Console.WriteLine($"\nTotal even numbers:{evenCount}");
        }
    }
}
