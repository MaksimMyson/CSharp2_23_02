namespace CSharp2_23_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть арифметичний вираз (з використанням + і -):");
            string expression = Console.ReadLine();

            double result = CalculateExpression(expression);

            Console.WriteLine($"Результат: {result}");

            Console.ReadLine(); 
        }

        static double CalculateExpression(string expression)
        {
            double result = 0;
            char operation = '+'; 

            
            string[] elements = expression.Split(new char[] { '+', '-' });

            foreach (string element in elements)
            {
                
                double number;
                if (double.TryParse(element, out number))
                {
                    
                    if (operation == '+')
                        result += number;
                    else if (operation == '-')
                        result -= number;
                }
                else
                {
                    Console.WriteLine("Некоректний вираз.");
                    return double.NaN; 
                }

                
                foreach (char c in element)
                {
                    if (c == '+' || c == '-')
                    {
                        operation = c;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
