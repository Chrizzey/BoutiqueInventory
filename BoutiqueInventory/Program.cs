using BoutiqueInventory.Articles;

namespace BoutiqueInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boutique Hans Mueller");

            var inventory = new Inventory();
            // inventory mit dummy daten füllen

            var consoleInterface = new InventoryConsoleInterface(inventory);
            consoleInterface.Start();
        }
    }
}
