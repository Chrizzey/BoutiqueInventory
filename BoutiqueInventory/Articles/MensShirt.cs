using System.Diagnostics;

namespace BoutiqueInventory.Articles
{
    [DebuggerDisplay("[ID {Number}] {Color} shirt in size {Size} for men")]
    public class MensShirt : Shirt
    {
        public ShirtSize Size { get ; set; }
    }
}