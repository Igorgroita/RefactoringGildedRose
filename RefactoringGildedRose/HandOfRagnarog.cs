using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringGildedRose
{
    class HandOfRagnarog : Item
    {
        public HandOfRagnarog(int sellIn, int quality) : base("Sulfuras, Hand of Ragnaros", sellIn, quality) { }
        public override void UpdateItemQuality()
        {
            //nothing
        }
    }
}
