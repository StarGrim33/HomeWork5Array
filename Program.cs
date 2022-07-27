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
            int startOfRepeat = 2;
            int bestLength = 0;
            int bestRepeat = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue, maxValue);
                Console.Write(numbers[i] + ",");
            }

            for (int i = 0; i < numbers.Length-2; i++)
            {
                if (numbers[i] == numbers[i+1])
                {
                    startOfRepeat = 2;
                    bestRepeat = startOfRepeat;

                }
                else if (numbers[i] == numbers[i+2])
                {
                    startOfRepeat += 1;
                    bestRepeat = startOfRepeat;
                }
                Console.WriteLine("Число: " + numbers[i] + " повторяется " + bestRepeat);
            }

        }
    }
}

