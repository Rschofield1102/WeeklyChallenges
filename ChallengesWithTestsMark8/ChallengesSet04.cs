using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {int sum = 0;
            foreach (int i in numbers)
            { if (i % 2 == 0)
                { sum += i; }
                else
                { sum -= i; }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };
            return list.Min();
            
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int>() { number1, number2, number3, number4 };
            return list.Min();
            
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {// void so dont return anything
            biz.Name = "TrueCoders";
           
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if( sideLength1 + sideLength2 <= sideLength3 ||
              sideLength2 + sideLength3 <= sideLength1 ||
              sideLength1 + sideLength3 <= sideLength2 )
            { return false;}
            else                            
            return true;
        }

        public bool IsStringANumber(string input)
        {
            double number;
            var result = double.TryParse(input, out number);
            return result;
           
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var majority = (objs.Length / 2) + 1;
            var count = 0;

            foreach (var item in objs)
            {
                if (item == null)
                {count++;}
            }
            if (count >= majority)
            { return true;}
            else
            { return false;}
        }

        public double AverageEvens(int[] numbers)
        {
            double sum = 0;
            double count = 0;
            if (numbers == null)
            { return 0;}

            foreach (var number in numbers)
            {
                if (number % 2 == 0)         
                { sum += number; count++;}
            }
            return (count > 0) ? sum / count : 0;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {throw new ArgumentOutOfRangeException();}

            if (number == 0)
            {return 1;}
            var factorial = 1;
            while (number != 1)
            { factorial = factorial * number;
                number = number - 1;
            }
            return factorial;
            
        }
    }
}
