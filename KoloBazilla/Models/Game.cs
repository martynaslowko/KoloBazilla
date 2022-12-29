using System;
using System.Collections.ObjectModel;

namespace KoloBazilla.Models
{
    internal class Game
    {
        private Wheel _wheel;
        private ObservableCollection<Player> _players;
        private Field _currentField;
        private Player _currentPlayer;
        private Password _password;
        private int _playerIterator = -1;
        private int _vowelPrice;

        public Game(ObservableCollection<Player> players, Wheel wheel, Password password, int vowelPrice)
        {
            _players = players;
            _wheel = wheel;
            _password = password;
            _vowelPrice = vowelPrice;
        }

        public void NextTurn()
        {
            if (_playerIterator == _players.Count - 1) _playerIterator = -1;
            _currentPlayer = _players[++_playerIterator];
            _currentField = RandomizeField();
        }

        public void TakeEffectInstant()
        {
            if (_currentField.name == Field.secondChance.name)
                _currentField = RandomizeField();
        }

        public void TakeEffectPositive()
        {
            if (_currentField.name == Field.money50.name)
                _currentPlayer.moneyCount += (int)_currentField.value;
            else if (_currentField.name == Field.smile.name)
                _currentPlayer.smileCount++;
        }

        public void TakeEffectNegative()
        { 
            if (_currentField.name == Field.bankrupt.name)
                _currentPlayer.moneyCount = 0;
        }

        public Field RandomizeField()
        {
            Random random = new Random();
            int idx = random.Next(wheel.fields.Count);
            return wheel.fields[idx];
        }

        public Wheel wheel => _wheel;

        public ObservableCollection<Player> players
        {
            get => _players;
            set => _players = value;
        }

        public Field currentField
        {
            get => _currentField;
            set => _currentField = value;
        }

        public Password password
        {
            get => _password;
            set => _password = value;
        }

        public Player currentPlayer
        {
            get => _currentPlayer;
            set => _currentPlayer = value;
        }

        public int vowelPrice
        {
            get => _vowelPrice;
            set => _vowelPrice = value;
        }
    }
}
