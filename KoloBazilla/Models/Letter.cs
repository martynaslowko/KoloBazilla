using System;

namespace KoloBazilla.Models
{
    internal class Letter
    {
        private char _value;
        private char _hiddenValue = '▯';
        private bool _isHidden;

        public Letter(char value)
        {
            _value = Char.ToUpper(value);
            _isHidden = Char.IsLetter(value);
        }

        public char value => _value;

        public char hiddenValue => _hiddenValue;

        public bool isHidden
        {
            get => _isHidden;
            set => _isHidden = value;
        }
    }
}
