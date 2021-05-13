namespace GildedRose {

    public class Realm {
        private string Name;

        public Realm(string name) {
            Name = name;
        }

        override
        public string ToString()
        {
            return $"{{Name: {Name}}}";
        }
    }
}