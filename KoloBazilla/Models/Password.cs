using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace KoloBazilla.Models
{
    internal class Password
    {
        private List<Letter> _letters;
        private string _incorrectLetters = "";

        public Password(string password)
        {
            _letters = PasswordToLetters(password.ToUpper());
        }

        public List<Letter> letters
        {
            get => _letters;
            set => _letters = value;
        }

        public string incorrectLetters
        {
            get => _incorrectLetters;
            set => _incorrectLetters = value;
        }

        public void ShowPassword()
        {
            foreach (Letter letter in _letters)
            {
                letter.isHidden = false;
            }
        }

        public bool CheckIfShown()
        {
            return _letters.All(letter => !letter.isHidden);
        }

        public bool CheckLetter(char character, bool vowelBought)
        {
            char[] vowels = {'A', 'Ą', 'E', 'Ę', 'I', 'O', 'U', 'Y' };
            bool result = false;
            if (vowels.Contains(character) && !vowelBought) 
                throw new Exception("Nie możesz używać samogłosek!");
            if (!vowels.Contains(character) && vowelBought)
                throw new Exception("Podaj samogłoskę!");
            if (LettersToString().Contains(character) || incorrectLetters.Contains(character))
                throw new Exception($"Litera {character} już została wykorzystana!");
            foreach (var letter in _letters.Where(letter => letter.isHidden).Where(letter => letter.value == character))
            {
                letter.isHidden = false;
                result = true;
            }
            return result;
        }

        private List<Letter> PasswordToLetters(string password)
        {
            return password.Select(character => new Letter(character)).ToList();
        }

        public string LettersToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Letter letter in _letters)
            {
                sb.Append(letter.isHidden ? letter.hiddenValue : letter.value);
            }
            return sb.ToString();
        }
    }
}
