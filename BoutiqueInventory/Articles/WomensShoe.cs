using System.Diagnostics;

namespace BoutiqueInventory.Articles
{
    [DebuggerDisplay("[ID {Number}] {Color} {Material} shoe for women")]
    public class WomensShoe : Footwear
    {
        /// <summary>
        /// Gets or sets the height of the heel in cm
        /// </summary>
        public double HeelHeight { get ; set; }
    }
}