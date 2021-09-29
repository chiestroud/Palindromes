using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Palindromes
{
    public class PalindromeChecker
    {
        public string Translate(string stringToTranslate)
        {
            string words = stringToTranslate;
            words = Regex.Replace(words, "[^a-zA-Z0-9_]", string.Empty);
            string reversedWords = "";
            
            for (var i = words.Length - 1; i >= 0; i--)
            {
                reversedWords += words[i];
            }
            if (words.ToLower() == reversedWords.ToLower())
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }
    }
}
