﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalyzer.Services;
namespace TextAnalyzer.Tests
{
    [TestFixture]
    public class CountVowelsServiceTests
    {
        private CountVowelsService _countVowelsService;
        [SetUp]
        public void SetUp()
        {
            _countVowelsService = new CountVowelsService();
        }

        [Test]
        public void TestCountVowels_WithVowels()
        {
            string input = "I like eating apples";

            var result = _countVowelsService.Execute(input);

            Assert.That(result, Is.EqualTo("The number of vowels is 3"));
        }

    }
}
