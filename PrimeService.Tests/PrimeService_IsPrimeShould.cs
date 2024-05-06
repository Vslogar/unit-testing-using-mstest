using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestClass]
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        [TestMethod]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            bool result = _primeService.IsPrime(1);

            Assert.IsFalse(result, "1 should not be prime");
        }

        [TestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        [DataRow(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.IsFalse(result, $"{value} should not be prime");
        }

        [TestMethod]
        public void MaxConsecutiveUnequalChars_EmptyString_ReturnsZero()
        {
            string input = "";
            int result = _primeService.MaxConsecutiveUnequalChars(input);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MaxConsecutiveUnequalChars_SingleCharacter_ReturnsOne()
        {
            string input = "a";
            int result = _primeService.MaxConsecutiveUnequalChars(input);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MaxConsecutiveUnequalChars_AllUniqueCharacters_ReturnsLength()
        {
            string input = "abcde";
            int result = _primeService.MaxConsecutiveUnequalChars(input);
            Assert.AreEqual(input.Length, result);
        }

        [TestMethod]
        public void MaxConsecutiveLatinLetters_ValidString_ReturnsCorrectCount()
        {
            string input = "aabbbccccddee";
            int result = _primeService.MaxConsecutiveLatinLetters(input);
            Assert.AreEqual(4, result); // 'c' appears consecutively 4 times
        }

        [TestMethod]
        public void MaxConsecutiveLatinLetters_NoLatinLetters_ReturnsZero()
        {
            string input = "12345";
            int result = _primeService.MaxConsecutiveLatinLetters(input);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MaxConsecutiveDigits_ValidString_ReturnsCorrectCount()
        {
            string input = "1122334455";
            int result = _primeService.MaxConsecutiveDigits(input);
            Assert.AreEqual(2, result); // '2' appears consecutively 2 times
        }

        [TestMethod]
        public void MaxConsecutiveDigits_NoDigits_ReturnsZero()
        {
            string input = "abcde";
            int result = _primeService.MaxConsecutiveDigits(input);
            Assert.AreEqual(0, result);
        }
    }

    //[TestClass]
    //public class StringUtilsTests
    //{
    //    private readonly StringUtils _stringUtils;
  

    //    [TestInitialize]
    //    public void Setup()
    //    {
    //        _stringUtils = new StringUtils();
    //    }

        
    //}
}