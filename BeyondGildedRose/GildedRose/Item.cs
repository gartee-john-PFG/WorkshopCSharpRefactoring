namespace GildedRose
{
    public class Item
    {
        public const string WEAPONS = "weapons";
        public const string APPAREL = "apparel";
        public const string POTIONS = "potions";
        public const string SCROLLS = "scrolls";
        public const string FOOD = "food";
        public const string INGREDIENTS = "ingredients";
        public const string BOOKS = "books";
        public const string KEYS = "keys";
        public const string MISC = "misc";
        
        public string Name;
        public int Quality;
        public int SellIn;
        public string Type;
        public int Weight;
        private int Value;
        private Character Owner;
        private Realm Realm;

        public Item(string name, int sellIn, int quality, string type, int weight, int value, Character owner, Realm realm)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
            Type = type;
            Weight = weight;
            Value = value;
            Owner = owner;
            Realm = realm;
        }

        override
        public string ToString()
        {
            return $"\tItem - {{Name: {Name}, Quality: {Quality}, SellIn: {SellIn}, Type: {Type}, Weight: {Weight}, Value: {Value}, \n\t\t\tCharacter: {Owner},\n\t\t\tRealm: {Realm}\n\t}}";
        }
    }


}
