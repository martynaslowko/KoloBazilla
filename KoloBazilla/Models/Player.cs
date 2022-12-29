namespace KoloBazilla.Models
{
    internal class Player
    {
        private string _name;
        private int _smileCount;
        private int _moneyCount;
        private bool _vowelBought;

        public Player(string name)
        {
            _name = name;
        }

        public int smileCount
        {
            get => _smileCount;
            set => _smileCount = value;
        }

        public int moneyCount
        {
            get => _moneyCount;
            set => _moneyCount = value;
        }
        public bool vowelBought
        {
            get => _vowelBought;
            set => _vowelBought = value;
        }

        public string name => _name;
    }
}
