using System.Collections.Generic;
using System.Linq;

namespace StringOrdinal.Core
{
    public static class StringOrdinal
    {
        private static Dictionary<char, char> ConstructSuperscript()
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz0123456789+-()";
            var ordinal = "ᵃᵇᶜᵈᵉᶠᵍʰⁱʲᵏˡᵐⁿᵒᵖˣʳˢᵗᵘᵛʷˣʸᶻ⁰¹²³⁴⁵⁶⁷⁸⁹⁺⁻⁽⁾";
            var listOrdinal =
                alphabet.Zip(ordinal, (c, c1) =>
                {
                    return new {c, c1};
                }).ToList().ToDictionary(a=> a.c, a=> a.c1);

            return listOrdinal;
        }
        
        private static Dictionary<char, char> ConstructSubscript()
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz0123456789";
            var ordinal = "₀₁₂₃₄₅₆₇₈₉";
            var listOrdinal =
                alphabet.Zip(ordinal, (c, c1) =>
                {
                    return new {c, c1};
                }).ToList().ToDictionary(a=> a.c, a=> a.c1);

            return listOrdinal;
        }

        public static string ConvertToSuperScript(this string word)
        {
            var superScript = string.Empty;
            var collection = ConstructSuperscript();

            var wordLowerCollection = word.ToLower().ToCharArray();
            foreach (var wordChar in wordLowerCollection)
            {
                superScript += collection.ContainsKey(wordChar) ? collection[wordChar] : char.Parse("");
            }

            return superScript;
        }
        
        public static string AddOrdinalToNumber(this int num)
        {
            if( num <= 0 ) return num.ToString();

            switch(num % 100)
            {
                case 11:
                case 12:
                case 13:
                    return num + ConvertToSuperScript("th");
            }

            switch(num % 10)
            {
                case 1:
                    return num + "st".ConvertToSuperScript();
                case 2:
                    return num + "nd".ConvertToSuperScript();
                case 3:
                    return num + "rd".ConvertToSuperScript();
                default:
                    return num + "th".ConvertToSuperScript();
            }
        }
        
        /*
         * public static string ConstructOrdinalToNumber(int num)
        {
            if( num <= 0 ) return num.ToString();

            switch(num % 100)
            {
                case 11:
                case 12:
                case 13:
                    return num + "ᵗʰ";
            }

            switch(num % 10)
            {
                case 1:
                    return num + "ˢᵗ";
                case 2:
                    return num + "ⁿᵈ";
                case 3:
                    return num + "ʳᵈ";
                default:
                    return num + "ᵗʰ";
            }
        }
         */
        
        
    }
}