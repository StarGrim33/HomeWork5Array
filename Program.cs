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
                for (int j = 0; j < numbers.Length -1; j++)
                {
                    if (numbers[j + 1] > numbers[j])
                    {
                        int sort = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = sort;
                    }
                }
            }

            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] == numbers[i+1])
                {
                    startCountKey++;
                    Console.Write(numbers[i]);
                }
            }
        }
    }
}
