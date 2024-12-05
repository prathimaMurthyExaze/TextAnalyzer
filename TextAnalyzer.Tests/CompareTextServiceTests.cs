using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalyzer.Services;

namespace TextAnalyzer.Tests
{
    [TestFixture]
    public class CompareTextServiceTests
    {
        private CompareTextService _compareTextService;

        [SetUp]
        public void Setup()
        {
            _compareTextService = new CompareTextService();
        }

        [Test]
        public void CompareTextService_WithMoreVowels()
        {
            string input = "I eat";

            var result = _compareTextService.Execute(input);

            Assert.That(result,Is.EqualTo("The text has more vowels than non vowels"));   
        }
    }
}
