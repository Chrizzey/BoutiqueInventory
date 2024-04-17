namespace BoutiqueInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boutique Hans Mueller");

            var inventory = new Inventory();
            if (IsStartedInDevMode(args))
            {
                // fill inventory with test data
                var dummyInventory = new DummyInventory();
                dummyInventory.Fill(inventory);
            }

            var consoleInterface = new InventoryConsoleInterface(inventory);
            consoleInterface.Start();
        }

        private static bool IsStartedInDevMode(IEnumerable<string> args)
        {
            return args.Contains("--dev");
        }
    }
}
