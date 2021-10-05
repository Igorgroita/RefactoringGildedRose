using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringGildedRose
{
    public class AgedBrie : Item
    {
        public AgedBrie(int sellIn, int quality) : base("Aged Brie", sellIn, quality) { }
        public override void UpdateItemQuality()
        {
            TryIncreaseQuality();
            SellIn--;
            if (SellIn < 0)
            {
                TryIncreaseQuality();
            }
        }

    }
}
