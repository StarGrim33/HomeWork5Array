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

            int maxNumberRepeat = 0;
            int countOfRepeat = 1;
            int maxCountRepeat = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue, maxValue);
                Console.Write(numbers[i] + ",");
            }

            for (int i = 0; i < numbers.Length - 2; i++)
            {

                if (numbers[i] == numbers[i + 1])
                {
                    countOfRepeat++;
                    maxCountRepeat = countOfRepeat;
                    maxNumberRepeat = numbers[i];
                    i++;

                    if (numbers[i] == numbers[i + 1])
                    {
                        countOfRepeat++;
                        maxCountRepeat = countOfRepeat;
                        maxNumberRepeat = numbers[i];
                        i++;
                    }
                    else if (numbers[i] != numbers[i + 1])
                    {
                        countOfRepeat = 1;
                        i++;
                    }

                }
                else 
                {
                    i++;
                }

            }
            Console.WriteLine("\n Число: " + maxNumberRepeat + " повторяется: " + maxCountRepeat + " раза.");
        }
    }
}