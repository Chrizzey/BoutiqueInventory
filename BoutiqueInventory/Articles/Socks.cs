using System.Diagnostics;

namespace BoutiqueInventory.Articles
{

    [DebuggerDisplay("[ID {Number}] {PackageSize}-pack of {Color} socks in size {Size}")]
    public class Socks : Footwear
    {
        /// <summary>
        /// Number of Socks sold as a unit
        /// </summary>
        public int PackageSize { get; set; }
    }
}