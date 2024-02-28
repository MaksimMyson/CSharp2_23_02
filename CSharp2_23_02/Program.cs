namespace CSharp2_23_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть речення:");
            string sentence = Console.ReadLine();

            Console.WriteLine("Кількість букв у речені:");

            int count = 0;

            foreach (char c in sentence)
            {
                if (char.IsLetter(c) || char.IsWhiteSpace(c))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
