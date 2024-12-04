using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalyzer.Interface;

namespace TextAnalyzer.Services
{
    public class CompareTextService : ITextAnalyserInterface
    {
        public string Execute(string text)
        {
            var vowels = "aeiou";
            var vowelsCount = text.ToLower().Count(c => vowels.Contains(c));
            var consonantsCount = text.Length - vowelsCount;

            if (consonantsCount > vowelsCount)
            {
                return "Consonants are more";
            }
            else
            {
                return "vowels are more";
            }

        }
    }
}
