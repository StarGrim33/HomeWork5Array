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
            int number = numbers.Length;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue, maxValue);
                Console.Write(numbers[i] + ",");
            }

            for (int i = 0; i < number-2; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    lenght = 2;
                    if (numbers[i+1] == numbers[i+2])
                    {
                        lenght++;
                        if (lenght > bestLenght)
                        {
                            bestLenght = lenght;
                            Console.WriteLine("\n Число: " + numbers[i] + " повторяется: " + bestLenght + " раз.");

                        }
                    }
                    
                }

                else
                {
                    lenght = 0;
                    Console.WriteLine("\nЭлементы равны и повторяются по два раза");
                }

            }

        }
    }
}