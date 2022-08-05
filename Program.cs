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

            int maxNumberRepeat = numbers[0];
            int maxCountRepeat = 1;
            int countOfRepeat = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue, maxValue);
                Console.Write(numbers[i] + ",");
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {

                if (numbers[i] == numbers[i + 1])
                {
                    countOfRepeat++;
                    
                    
                    if (countOfRepeat > maxCountRepeat)
                    {
                        maxCountRepeat = countOfRepeat;
                        maxNumberRepeat = numbers[i];
                    }
                    
                }
               
                else if (numbers[i] != numbers[i + 1])
                {
                    if (countOfRepeat > maxCountRepeat)
                    {
                        maxCountRepeat = countOfRepeat;
                    }
                    else
                    {
                        countOfRepeat = 1;
                    }
                }

            }
            Console.WriteLine("\n Число: " + maxNumberRepeat + " повторяется: " + maxCountRepeat + " раза.");
        }
    }
}