namespace ProjectEuler
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");
        }

        static int GetEvenNumbersFromFibonacciSequence(int number)
        {
            int result = 0;

            int firstNumber = 1;
            int secondNumber = 2;

            int temp;

            while (secondNumber < number)
            {
                if (secondNumber % 2 == 0)
                    result += secondNumber;

                temp = secondNumber;
                secondNumber = firstNumber + secondNumber;
                firstNumber = temp;
            }

            return result;
        }

        static int CountSumOfMultiples(int destinationNumber, params int[] multiples)
        {
            int result = 0;
            int multiplesLength = multiples.Length;
            int j = 0;

            for (int i = 1; i < destinationNumber; ++i)
            {
                for (; j < multiplesLength; ++j)
                {
                    if (i % multiples[j] == 0)
                    {
                        result += i;
                        break;
                    }
                }

                j = 0;
            }

            return result;
        }
    }
}