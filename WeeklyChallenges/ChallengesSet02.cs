using System;
using System.Collections.Generic;
using System.Linq;

namespace WeeklyChallenges
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return true;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            var valLength =  vals.Length;
            return valLength % 2 == 0 ? true : false;
        }

        public bool IsNumberEven(int number)
        {
           return number % 2 == 0 ? true : false; 
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 == 0 ? false : true;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var strLen1 = str1.Length;
            var strLen2 = str2.Length;
            if (strLen1 < strLen2) { return str1.Length;} else { return str2.Length; }
        }

        public int Sum(int[] numbers)
        {

            return numbers==null? 0: numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            var evenSum = new List<int>() ;

            if (numbers == null) 
                { return 0; } 
                    else 
                {
                foreach (int num in numbers)
                {
                    if (num % 2 == 0) { evenSum.Add(num); }
                }
            }
            return evenSum.Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return numbers == null || numbers.Sum()%2==0? false: true;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number > 0 ? number/2: 0 ;
        }
    }
}
