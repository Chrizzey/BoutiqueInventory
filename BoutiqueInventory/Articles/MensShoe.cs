using System.Diagnostics;

namespace BoutiqueInventory.Articles
{
    [DebuggerDisplay("[ID {Number}] {Color} {Material} shoe for men")]
    public class MensShoe : Footwear
    {
        public bool HasLaces { get ; set; }
    }
}