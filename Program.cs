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
                       
                    }
                    Console.WriteLine("Число: " + numbers[i] + "," + bestLenght);
                }
                else if (i != 0 && lenght != 0 && numbers[i] == numbers[i - 1] && numbers[i + 1] == numbers[i])
                {
                    lenght++;

                    if (lenght > bestLenght)
                    {
                        bestLenght = lenght;
                    }
                    Console.WriteLine("Число: " + numbers[i] + "," + bestLenght);

                }
                else if (i != 0 && numbers[i - 1] != numbers[i] && numbers[i] == numbers[i + 1])
                {
                   
                    lenght = 2;

                    if (lenght > bestLenght)
                    {
                        bestLenght = lenght;
                        
                    }
                    Console.WriteLine("Число: " + numbers[i] + "," + bestLenght);

                }
                else
                {
                    lenght = 0;
                }

            }
            Console.WriteLine("\nСамый длинный повтор: " + bestLenght + ",");

        }
    }
}

