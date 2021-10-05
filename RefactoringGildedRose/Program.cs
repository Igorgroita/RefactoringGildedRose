using System;
using System.Collections.Generic;

namespace RefactoringGildedRose
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<Item> Items = new List<Item>{
                new Item("+5 Dexterity Vest",10, 20),
                new AgedBrie(2,0),
                new Item("Elixir of the Mongoose",5,7),
                new HandOfRagnarog(0,80),
                new HandOfRagnarog(-1, 80),
                new BackstagePasses(15,20),
                new BackstagePasses(10,49),
                new BackstagePasses(5,49),
                new Item("Conjured Mana Cake",3,6)
            };

            var app = new GildedRose(Items);

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j]);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}