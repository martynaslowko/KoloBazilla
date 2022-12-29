namespace KoloBazilla.Models
{
    internal class Field
    {
        private string _name;
        private int? _value;

        private Field(string name, int? value = null)
        {
            _name = name;
            _value = value;
        }

        public static Field smile => new Field("Uśmiech");
        public static Field drink => new Field("Pijemy");
        public static Field bankrupt => new Field("Bankrut");
        public static Field ban => new Field("Ban");
        public static Field turnLoss => new Field("Strata kolejki");
        public static Field secondChance => new Field("Druga szansa");
        public static Field money50 => new Field("Ziko", 50);
        public static Field money100 => new Field("Ziko", 100);
        public static Field money150 => new Field("Ziko", 150);

        public string name => _name;
        public int? value => _value;
    }
}
