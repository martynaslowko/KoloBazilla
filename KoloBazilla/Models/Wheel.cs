using System.Collections.Generic;

namespace KoloBazilla.Models
{
    internal class Wheel
    {
        public enum Type
        {
            Default
        }

        private List<Field> _fields;

        public Wheel(Type type)
        {
            switch (type)
            {
                case Type.Default:
                    _fields = defaultFields();
                    break;
                default:
                    _fields = new List<Field>();
                    break;
            }
        }

        public List<Field> fields => _fields;

        private List<Field> defaultFields()
        {
            List<Field> newFields = new List<Field>()
            {
                Field.smile,
                Field.drink,
                Field.drink,
                Field.drink,
                Field.drink,
                Field.bankrupt,
                Field.bankrupt,
                Field.ban,
                Field.turnLoss,
                Field.secondChance,
                Field.money150,
                Field.money100,
                Field.money100,
                Field.money50
            };
            return newFields;
        }
    }
}
