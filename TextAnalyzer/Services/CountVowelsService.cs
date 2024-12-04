using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalyzer.Interface;

namespace TextAnalyzer.Services
{
    public class CountVowelsService : ITextAnalyserInterface
    {
        public string Execute(string text)
        {
         

            var vowels = "aeiou";
            var uniqueVowels = text.ToLower().Where(c => char.IsLetter(c)).Where(c => vowels.Contains(c)).Distinct();

            return uniqueVowels.Any() ? $"vowels count : {uniqueVowels.Count()}" : "no vowels found";

        }
    }
}
