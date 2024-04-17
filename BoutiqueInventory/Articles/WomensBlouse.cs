using System.Diagnostics;

namespace BoutiqueInventory.Articles
{
    [DebuggerDisplay("[ID {Number}] {Color} shirt in size {Size} for women")]
    public class WomensBlouse : Shirt
    {
        public int Size { get; set; }
    }
}