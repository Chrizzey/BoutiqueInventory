using System.Diagnostics;

namespace BoutiqueInventory.Articles
{
    [DebuggerDisplay("[ID {Number}] {Color} {Material} hat in size {Size}")]
    public class Hat : Article
    {
        public double Size { get; set; }
    }
}