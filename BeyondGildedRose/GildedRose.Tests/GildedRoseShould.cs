namespace GildedRose.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using ApprovalTests;
    using ApprovalTests.Reporters;
    using Xunit;


    [UseReporter(typeof(DiffReporter))]
    public class GildedRoseShould
    {
        [Fact]
        public void FindTheGildedRoseClass()
        {
            string[] name = { "hammer", "Aged Brie", "Backstage passes to a TAFKAL80ETC concert", "Sulfuras, Hand of Ragnaros" };
            int[] sellIn = new int[] {  -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            var quality = new int[] { 0, 1, 2, 48, 49, 50, 51 };

            ApprovalTests.Combinations.CombinationApprovals.VerifyAllCombinations(DoUpdate, name, sellIn, quality);

        }

        private static string DoUpdate(string Name, int SellIn, int Quality)
        {
            GildedRose gr = new GildedRose(new Item[] {
                new Item(Name, SellIn, Quality, "weapon", 1, 1,
                new Character("fred","M",1,"warrior","elf"),
                new Realm("Atlantis"))
            });

            gr.UpdateQuality();

            var result = gr.Items[0].ToString();
            return result;
        }
    }
}
