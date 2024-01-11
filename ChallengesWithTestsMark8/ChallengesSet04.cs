using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public static int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
        }
        
        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length};
            return list.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var num = new List<int>() { number1, number2, number3, number4};
            return num.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return
            (
                sideLength1 + sideLength2 > sideLength3 &&
                sideLength2 + sideLength3 > sideLength1 &&
                sideLength1 + sideLength3 > sideLength2
            );
            
            

        }
        public bool IsStringANumber(string input)
        {
            var isNum = double.TryParse(input, out var num);
            return isNum;
        }
        

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var numObj = objs.Count();
            var majority = (numObj / 2) + 1;
            var count = 0;
            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    count++;
                }
            }
                if (count >= majority)
                {
                    return true;
                }
                return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            
            var y = numbers.Where(x => x % 2 == 0);
            if (y.Any() == false)
            {
                return 0;
            }
            return y.Average();
        }

        public int Factorial(int number)
        {
            var fact = 1;
            
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = number; i > 0; i--)
            {
                fact *= i;
            }

            return fact;
        }
        public int NegativeFactorialShouldThrowOutOfRangeException(int number)
        {
            var fact = 1;

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = number; i > 0; i--)
            {
                fact *= i;
            }

            return fact;
        }
        
    }
}
