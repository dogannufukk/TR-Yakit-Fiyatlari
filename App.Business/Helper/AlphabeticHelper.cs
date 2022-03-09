using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Helper
{
    public static class AlphabeticHelper
    {

        public static string ConvertCharToEnglishAlphabeticalCharacter(string text)
        {
            var result = text
                .Replace("Ç", "C")
                .Replace("ç", "c")
                .Replace("Ğ", "G")
                .Replace("ğ", "g")
                .Replace("İ", "I")
                .Replace("Ö", "O")
                .Replace("ö", "o")
                .Replace("Ş", "S")
                .Replace("ş", "s")
                .Replace("Ü", "U")
                .Replace("ü", "u");
            return result;
        }
        public static string StringToUpperCase(string text)
        {
            return text.ToUpper();
        }
        public static string FirstLetterToUpperCase(string text)
        {
            text = text.TrimStart().TrimEnd();
            var textArray = text.Split(' ');
            var stringArray = "";
            string changeString;
            foreach (var substring in textArray)
            {
                if (String.IsNullOrEmpty(substring))
                {
                    changeString = "";
                }
                else if (text.Length == 1)
                {
                    changeString = substring.ToUpper();
                }
                else
                {
                    changeString = char.ToUpper(substring[0]) + substring.Substring(1).ToLower();
                }
                stringArray += changeString + " ";
            }
            return stringArray.TrimEnd();

        }
    }


}

