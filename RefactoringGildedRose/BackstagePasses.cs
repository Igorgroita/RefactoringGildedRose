using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringGildedRose
{
    class BackstagePasses : Item
    {
        public BackstagePasses(int sellIn, int quality)
            : base("Backstage passes to a TAFKAL80ETC concert", sellIn, quality) { }

        public override void UpdateItemQuality()
        {
            TryIncreaseQuality();
            if (SellIn < 11)
            {
                TryIncreaseQuality();
            }
            if (SellIn < 6)
            {
                TryIncreaseQuality();
            }
            SellIn--;
            if (SellIn < 0)
            {
                Quality = 0;
            }
        }
    }
}
