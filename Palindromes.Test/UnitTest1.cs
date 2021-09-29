using System;
using Xunit;

namespace Palindromes.Test
{
    public class UnitTest1
    {
        
        //public void words_are_reversed_to_check_if_it_is_a_palindrome()
        //{
        //    var stringToTranslate = "Amore, Roma";
        //    var expectedResult = "true";
        //    var translator = new PalindromeChecker();

        //    string actualResult = translator.Translate(stringToTranslate);

        //    Assert.Equal(expectedResult, actualResult);
        //}

        [Theory]
        [InlineData("Stars", "false")]
        [InlineData("O, a kak Uwakov lil vo kawu kakao!", "true")]
        [InlineData("Some men interpret nine memos", "true")]
        [InlineData("Stats", "true")]
        public void check_if_a_given_string_is_palindrome(string stringToTranslate, string expectedResult)
        {
            var translator = new PalindromeChecker();

            string actualResult = translator.Translate(stringToTranslate);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
