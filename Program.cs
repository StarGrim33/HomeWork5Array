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

            int nextAdjacentNumber = 1;
            int maxNumberRepeat = 0;
            int countOfRepeat = 0;
            int maxCountRepeat = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue, maxValue);
                Console.Write(numbers[i] + ",");
            }

            for (int i = 0; i < numbers.Length-1; i++)
            {
                countOfRepeat = 1;

                if (numbers[i] == numbers[i + nextAdjacentNumber])
                {
                    countOfRepeat++;
                    maxCountRepeat = countOfRepeat;
                    maxNumberRepeat = numbers[i];
                }
                else if (countOfRepeat > maxCountRepeat)
                {
                    maxCountRepeat = countOfRepeat;
                    maxNumberRepeat = numbers[i];
                }
                else
                {
                    countOfRepeat = 0;
                    i++;
                }
      
            }
            Console.WriteLine("\n Число: " + maxNumberRepeat + " повторяется: "  + maxCountRepeat + " раза.");
        }
    }
}