namespace CSharp2_23_02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть речення:");
            string sentence = Console.ReadLine();

            string reversedSentence = ReverseWordsInSentence(sentence);

            Console.WriteLine("Після перевороту: " + reversedSentence);
        }

        public static string ReverseWordsInSentence(string sentence)
        {
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }
}
