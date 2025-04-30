namespace Heaith_Potion_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Console.WriteLine(" Health before potion:" + player.Health);

            Player.UseHealthPotion();
            Console.WriteLine("Health after potion" + player.Health);
        }
    }
}
