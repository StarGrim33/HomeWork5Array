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
            int countOfRepeat = 0;
            int startCountKey = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue, maxValue);
                Console.Write(numbers[i] + ",");
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j + 1] > numbers[j])
                    {
                        int sort = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = sort;
                    }
                }
            }

            Console.WriteLine("\nОтсортированный массив по порядку: ");

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                Console.Write(numbers[i] + ",");

            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int k = i + 1; k < numbers.Length; k++)
                {
                    if (numbers[i] == numbers[k])
                    {
                        countOfRepeat++;
                    }
                    else
                    {
                        countOfRepeat = 0;
                    }
                    Console.WriteLine(countOfRepeat);
                }
            }
        }
    }
}

