using NUnit.Framework;

namespace roman_numerals
{
    [TestFixture]
    public class RomanNumeralsTests
    {
        private readonly Converter _converter = new Converter();

        [TestCase(0,"")]
        [TestCase(1,"I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4,"IV")]
        [TestCase(5, "V")]
        [TestCase(10, "X")]
        [TestCase(32, "XXXII")]
        [TestCase(38,"XXXVIII")]
        public void ConvertsNumberToRomanNumeral(int number,string expectedNumeral)
        {
            Assert.That(_converter.ConvertToRomanNumeral(number), Is.EqualTo(expectedNumeral));
        }

       

        
    }
}
