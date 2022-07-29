namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[30];
            Random random = new Random();
            int minValue = 1;
            int maxValue = 10;

            int lenght = 0;
            int bestLenght = 0;
            int number1 = 0;
            int number2 = 0;
            int number3 = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue, maxValue);
                Console.Write(numbers[i] + ",");
            }

            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (i == 0 && numbers[i] == numbers[i + 1])
                {
                    lenght = 2;

                    if (lenght > bestLenght)
                    {
                        bestLenght = lenght;
                        number1 = numbers[i];

                    }
                    Console.WriteLine("\nЧисло: " + numbers[i] + " повторяется: " + bestLenght);

                }
                else if (i != 0 && lenght != 0 && numbers[i] == numbers[i - 1] && numbers[i + 1] == numbers[i])
                {
                    lenght++;

                    if (lenght > bestLenght)
                    {
                        bestLenght = lenght;
                        number2 = numbers[i];

                    }
                    Console.WriteLine("\nЧисло: " + numbers[i] + " повторяется: " + bestLenght);

                }
                else if (i != 0 && numbers[i - 1] != numbers[i] && numbers[i] == numbers[i + 1])
                {
                    lenght = 2;

                    if (lenght > bestLenght)
                    {
                        bestLenght = lenght;
                        number3 = numbers[i];

                    }
                    Console.WriteLine("\nЧисло: " + numbers[i] + " повторяется: " + bestLenght);

                }
                else
                {
                    lenght = 0;
                }
                

            }
            if (number1 > number2)
            {
                Console.WriteLine(number1 + bestLenght);
            }
            else if (number2 > number1)
            {
                Console.WriteLine(number2 + bestLenght);

            }
            else
            {
                Console.WriteLine(number3 + bestLenght);
            }

        }
    }
}

