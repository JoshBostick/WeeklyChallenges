using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
           if (words == null || words.Contains(null))
            {
                return false;
            }
            
            bool containsWord = false;

            if (ignoreCase)
            {
                word = word.ToLower();

                List<string> lowerCase = words.Select(x => x.ToLower()).ToList();

                containsWord = lowerCase.Contains(word);
            }
            
            if (!ignoreCase)
            {
                containsWord = words.Contains(word);
            }

            return containsWord;
    
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            if (num == 2 || num == 3)
            {
                return true;
            }

            if (num % 2 != 0 && num % 3 != 0)
            {
                return true;
            }

            return false;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            var index = -1;
            bool uIndex;

            for (int i = 0; i < str.Length; i++)
            {
                uIndex = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uIndex = false;
                    }
                }

                if (uIndex == true)
                {
                    index = i;
                }
            }

            return index;

        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            var count = 0;

            for (var i = 0;i < numbers.Length;i++)
            {
                var curCount = 1;

                for (var j = i +1;j < numbers.Length;j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }

                    curCount++;
                }
                
                if (curCount > count)
                {
                    count = curCount;
                }
            }

            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var nElement = new List<double>();

            if (elements  ==  null || n <= 0 || n > elements.Count)
            {
                return nElement.ToArray();
            }

            for (var i = n - 1; i < elements.Count;i += n) 
            {
                nElement.Add(elements[i]);
            }

            return nElement.ToArray();
        }
    }
}
