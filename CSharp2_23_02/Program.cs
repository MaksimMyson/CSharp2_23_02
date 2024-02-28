namespace CSharp2_23_02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть речення:");
            string sentence = Console.ReadLine();

            int vowelCount = CountVowels(sentence);

            Console.WriteLine($"Кількість голосних літер у реченні: {vowelCount}");
        }

        public static int CountVowels(string sentence)
        {
            int count = 0;
            foreach (char c in sentence)
            {
                if (IsVowel(c))
                {
                    count++;
                }
            }
            return count;
        }

        public static bool IsVowel(char c)
        {
            
            switch (char.ToLower(c))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return true;
                default:
                    return false;
            }
        }
    }
}