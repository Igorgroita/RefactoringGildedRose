using System;

namespace RefactoringGildedRose
{
    public class Item
    {
        public string Name { get; private set; }
        public int SellIn { get; protected set; }
        public int Quality { get; protected set; }

        public Item(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }
        protected void TryIncreaseQuality()
        {
            Quality = Math.Min(50, Quality++);
        }
        public virtual void UpdateItemQuality()
        {
            Quality = Math.Max(0, Quality - 1 - --SellIn < 0 ? 1 : 0);
        }

    }
}