using TextAnalyzer.Services;

namespace TextAnalyzer.Tests
{
    [TestFixture]
    public class DuplicateCheckServiceTests
    {
        private DuplicateCheckService _duplicateCheckService;

        [SetUp]
        public void Setup()
        {
            _duplicateCheckService = new DuplicateCheckService();   
        }

        [Test]
        public void TestDuplicateCheck_WithDuplicates()
        {
            string input = "I like eating apples";

            string result = _duplicateCheckService.Execute(input);

            Assert.That(result, Is.EqualTo("Found the following duplicates : ileap"));
        }
    }
}