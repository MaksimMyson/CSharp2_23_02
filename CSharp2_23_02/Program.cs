using System.Text.RegularExpressions;
namespace CSharp2_23_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть текст:");
            string inputText = Console.ReadLine();

            string result = ChangeCaseOfSentences(inputText);

            Console.WriteLine("Результат:");
            Console.WriteLine(result);

            Console.ReadLine(); 
        }

        static string ChangeCaseOfSentences(string text)
        {
            
            string[] sentences = Regex.Split(text, @"(?<=[\.!\?])\s+");

            
            for (int i = 0; i < sentences.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(sentences[i]))
                {
                    sentences[i] = char.ToUpper(sentences[i][0]) + sentences[i].Substring(1);
                }
            }

            
            return string.Join(" ", sentences);
        }
    }
}
