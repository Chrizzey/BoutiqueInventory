namespace BoutiqueInventory.Articles
{
    public abstract class Shirt : Article
    {
        // Todo: use enum for full, half, three-quaters and short
        public int SleeveLength { get; set; }
    }
}