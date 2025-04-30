using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class VendingMachine
    {
        private string[] items;
        private double[] prices;
        private int[] stock;
        public double Balance { get; private set; }
        public VendingMachine(string[] items, double[] prices, int[] stock)
        {
            this.items = items;
            this.prices = prices;
            this.stock = stock;
            Balance = 0.0;
        }
        public void DisplayItems()
            {
            Console.WriteLine("Items available for purchase:");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i]} - ${prices[i]:0.00} OMR (Stock: {stock[i]})");
            }
        }
        public bool BuyItem(string itemName, double payment)
        {
            int itemIndex = Array.IndexOf(items, itemName);
            if (itemIndex == -1)
            {
                Console.WriteLine("Item not found.");
                return false;
            }
            if (stock[itemIndex] <= 0)
            {
                Console.WriteLine("Item out of stock.");
                return false;
            }
            if (payment < prices[itemIndex])
            {
                Console.WriteLine("Insufficient payment.");
                return false;
            }
            stock[itemIndex]--;
            Balance += prices[itemIndex];
            Console.WriteLine($"Purchased {itemName} for ${prices[itemIndex]}.");
            return true;
        }
    }
}
