using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalyzer.Interface;

namespace TextAnalyzer.Services
{
    public class DuplicateCheckService : ITextAnalyserInterface
    {
        public string Execute(string text)
        {
            var duplicates = text.ToLower()
               .Where(c => char.IsLetter(c))
               .GroupBy(c => c)
               .Where(g => g.Count() > 1)
               .Select(g => g.Key)
               .Distinct();

            return duplicates.Any() ? $"Found the following duplicates : {string.Join("", duplicates)}" : "No duplicate values were found";
        }
    }
}
