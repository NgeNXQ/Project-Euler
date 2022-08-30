﻿using System.Collections.Generic;

namespace ProjectEuler
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(CalculateProblemSix());
        }

        #region 1

        /*
            If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
            Find the sum of all the multiples of 3 or 5 below 1000.
        */

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
        #endregion

        #region 2

        /*
            Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
            1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
            By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
        */

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
        #endregion

        //May be improved
        #region 3

        /*
            The prime factors of 13195 are 5, 7, 13 and 29.
            What is the largest prime factor of the number 600851475143 ?   
        */

        static long GetAllPrimeFactors(long number)
        {
            long lastNumber = -1;
            bool isAppropriate = true;

            for (long i = 2; i <= number; ++i)
            {
                if (number % i == 0)
                {
                    for (long j = 2; j < i; ++j)
                    {
                        if (i % j == 0)
                        {
                            isAppropriate = false;
                            break;
                        }
                    }

                    if (isAppropriate)
                        lastNumber = i;
                    else
                        isAppropriate = true;
                }
            }

            return lastNumber;
        }
        #endregion

        #region 4

        /*
            A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
            Find the largest palindrome made from the product of two 3-digit numbers. 
        */

        //static void FindLargestPalindromeNumber(int number)
        //{
        //    //GetAllNumbers(number);

        //    int firstNumber = 999;
        //    int secondNumber = 999;

        //    int temp

        //    while (firstNumber >= 100)
        //    {
        //        while(secondNumber >= 100)

        //    }

        //    void GetAllNumbers(int number)
        //    {
        //        int lastDigit;

        //        while (number >= 1)
        //        {
        //            lastDigit = number % 10;
        //            number = (number - lastDigit) / 10;
        //        }
        //    }
        //}
        #endregion

        #region 5
        /*
            2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
            What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        */
        #endregion

        #region 6

        /*
            The sum of the squares of the first ten natural numbers is,
            The square of the sum of the first ten natural numbers is,
            Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is .
            Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        */
        
        static int CalculateProblemSix()
        {
            return GetSquareOfSum() - GetSumOfSquares();

            int GetSumOfSquares()
            {
                int result = 0;

                for (int i = 1; i <= 100; ++i)
                    result += i * i;

                return result;
            }

            int GetSquareOfSum()
            {
                int result = 0;

                for (int i = 1; i <= 100; ++i)
                    result += i;

                return result * result;
            }
        }
        #endregion
    }
}