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

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue, maxValue);
                Console.Write(numbers[i] + ",");
            }

            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] == numbers[i+1])
                {
                    
                    if (numbers[i+1] == numbers[i+2])
                    {
                        startOfRepeat += 1;
                    }
                    else
                    {
                        startOfRepeat = 2;
                    }
                    Console.Write("\nПовторяющиеся числа: " + numbers[i] + " - " + startOfRepeat);
                }
                
   
            }

        }
    }
}

