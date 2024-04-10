using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        { return char.IsLetter(c); }
            // did this one on CodeWars. It was quite fun to learn 
        

        public bool CountOfElementsIsEven(string[] vals)
        { return (vals.Length % 2 == 0 ? true : false); }
            // always learning. Spent a while learning this one! 

        public bool IsNumberEven(int number)
        { return number % 2 == 0 ? true : false; }

        public bool IsNumberOdd(int num)
        { return num % 2 != 0 ? true : false; }
            // Thank you for showing me the not symbol today :)
        

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || !numbers.Any())
            { return 0; }
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            { return str1.Length; }
            else
            { return str2.Length; }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            { return 0; }
            int sum = 0;
            foreach (int i in numbers)
            { sum += i; }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            var sums = 0;
            if (numbers == null)
            { return 0; }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                { sums += numbers[i]; }
            }
            return sums;
        }


        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            { return false; }
            int sum = Sum(numbers.ToArray());
            return sum % 2 == 0 ? false : true;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int count= 0;
            for (int i = 0; i < number; i++)
            { if (i % 2 != 0)
                { count++; }
            }
            return count;
        }
    }
}

