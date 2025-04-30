namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] items = { "Chips", "Soda", "Chocolate" };
            double[] prices = { 1.50, 1.00, 2.00 };
            int[] stock = { 3, 2, 1 };
            VendingMachine vm = new VendingMachine(items, prices, stock);
            Console.WriteLine("Welcome to the Code Academy Vending Machine!");

            bool keepRunning = true;
            while (keepRunning)
            {
                vm.DisplayItems();

                Console.Write("Enter item name: ");
                string itemName = Console.ReadLine();

                Console.Write("Enter your payment: ");
                if (double.TryParse(Console.ReadLine(), out double payment))
                {
                    vm.BuyItem(itemName, payment);
                }
                else
                {
                    Console.WriteLine("Invalid payment input.");
                }
                Console.Write("Do you want to buy another item? (yes/no): ");
                string response = Console.ReadLine();
                if (!response.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    keepRunning = false;
                }
            }
            Console.WriteLine($"Thank you! Total money collected: {vm.Balance:0.00} OMR");
        }
    }
}

