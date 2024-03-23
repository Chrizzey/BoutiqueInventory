namespace BoutiqueInventory
{
    public class InventoryConsoleInterface
    {
        private readonly Inventory _inventory;

        public InventoryConsoleInterface(Inventory inventory)
        {
            _inventory = inventory;
        }

        public void Start()
        {
            bool @continue;
            do
            {
                PrintMainMenu();
                var choice = Console.ReadLine();
                @continue = InvokeAction(choice);
            } while(@continue);
        }

        private void PrintMainMenu()
        {
            // Console.WriteLine(..)
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="choice"></param>
        /// <returns>false if user wants to exit, otherwise true</returns>
        private bool InvokeAction(string? choice)
        {
            switch (choice)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;

                case "exit":
                case "quit":
                case "e":
                case "q":
                    return false;
            }

            return true;
        }

        private void ChangePrice(int articleNumber, decimal newPrice)
        {
            var article = _inventory.GetArticleByNumber(articleNumber);
            article.Price = newPrice;
        }
    }
}