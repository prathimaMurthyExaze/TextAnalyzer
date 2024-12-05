using TextAnalyzer.Interface;
using TextAnalyzer.Services;

namespace TextAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTextAnalyzer();
        }

        private static void RunTextAnalyzer()
        {
            while (true)
            {
                Console.WriteLine("Enter text to be analysed");
                string inputText = Console.ReadLine()!;

                Console.WriteLine("Enter which operations to do on the supplied text: ");
                Console.WriteLine("'1' for a duplicate character check");
                Console.WriteLine("'2' to count the number of vowels, ");
                Console.WriteLine("'3' to check if there are more vowels or non-vowels");
                Console.WriteLine(" Or any combination of '1', '2' and '3' to perform multiple checks.");
                string operations = Console.ReadLine()!;

                Dictionary<char, ITextAnalyserInterface> services = IntializeServices();

                ProcessOperation(inputText, operations, services);

                Console.WriteLine(" Do you want to continue further? yes/no");
                string continueText = Console.ReadLine()!;

                if(continueText.Equals("no",StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            }
        }

        private static Dictionary<char, ITextAnalyserInterface> IntializeServices()
        {
            return new Dictionary<char, ITextAnalyserInterface>
            {
                { '1',new DuplicateCheckService() },
                { '2',new CountVowelsService() },
                { '3',new CompareTextService() }
            };
        }

        private static void ProcessOperation(string inputText, string operations, Dictionary<char, ITextAnalyserInterface> services)
        {
            foreach (var operation in operations)
            {
                if (services.ContainsKey(operation))
                {
                    Console.WriteLine(services[operation].Execute(inputText));
                }
                else
                {
                    Console.WriteLine("select valid operation");
                }
            }
        }
    }
}
