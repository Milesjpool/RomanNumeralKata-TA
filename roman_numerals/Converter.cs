using System.Collections.Generic;

namespace roman_numerals
{
    public class Converter
    {
        private Dictionary<int, string> _numeralDictionary = new Dictionary<int, string>
            {
                {0,""},
                {1,"{0}"},
                {2,"{0}{0}"},
                {3,"{0}{0}{0}"},
                {4, "{0}{1}"},
            };

        public string ConvertToRomanNumeral(int number)
        {
            return Tens(number) + Five(number) + Units(number);
        }

        private string Tens(int number)
        {
            var ten = "X";
            var fifty = "L";
            var tens = _numeralDictionary[number / 10];
            return string.Format(tens, ten, fifty);
        }

        private string Five(int number)
        {
            var five = "V";
            var fives = _numeralDictionary[(number % 10) /5];
            return string.Format(fives, five);

        }

        private string Units(int number)
        {
            var one = "I";
            var five = "V";
            var units = _numeralDictionary[number % 5];
            return string.Format(units, one, five);
        }
    }
}