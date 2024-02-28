namespace CSharp2_23_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть рядок для шифрування:");
            string input = Console.ReadLine();

           
            int shift = 3;

           
            string encrypted = Encrypt(input, shift);
            Console.WriteLine($"Зашифрований рядок: {encrypted}");

            
            string decrypted = Decrypt(encrypted, shift);
            Console.WriteLine($"Розшифрований рядок: {decrypted}");

            Console.ReadLine(); 
        }

        static string Encrypt(string input, int shift)
        {
            string result = "";

            foreach (char symbol in input)
            {
                
                if (char.IsLetter(symbol))
                {
                    
                    int code = (int)symbol;

                    
                    bool isUpper = char.IsUpper(symbol);

                    
                    code += shift;

                    
                    if (isUpper && code > (int)'Z')
                        code -= 26;
                    else if (!isUpper && code > (int)'z')
                        code -= 26;

                    
                    result += (char)code;
                }
                else
                {
                    
                    result += symbol;
                }
            }

            return result;
        }

        static string Decrypt(string input, int shift)
        {
            
            return Encrypt(input, -shift);
        }
    }
}
