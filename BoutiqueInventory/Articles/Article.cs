namespace BoutiqueInventory.Articles
{
    public abstract class Article
    {
        private decimal _price;

        public int Number { get; set; }

        public decimal Price
        {
            get => _price;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be less than 0");
                }
                
                _price = value;
            }
        }

        public string Color { get; set; }

        public string Material { get; set; }

        public string Description { get; set; }
    }
}
