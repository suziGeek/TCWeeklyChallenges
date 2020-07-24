using System;
using System.Collections.Generic;
using System.Linq;

namespace WeeklyChallenges
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false) ;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {   if(numbers == null)
            { return false; }
           
            int x = 0;
            foreach (var item in numbers)
            {
                if( item%2 != 0 )
                {
                    x = x + item;
                }
            }
            return x%2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return 
                password.Any(c => char.IsUpper(c)) &&
                password.Any(c => char.IsDigit(c)) &&
                password.Any(c => char.IsLower(c)); 
        }

        public char GetFirstLetterOfString(string val)
        { 
            
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            int last = val.Length - 1;
            return val[last];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor == 0)
            { return 0; }
            return dividend/divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            var last = nums.Length-1;

            var first = nums[0];

            var sum = nums[last] - first;

            return sum;
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();

            for (int x = 1; x < 100; x = x + 2)
                { odds.Add(x); }

            return odds.ToArray();
        }

        public string[] ChangeAllElementsToUppercase(string[] words)
        {

            for (int i = 0; i < words.Length; i++)
            { words[i] = words[i].ToUpper(); }

            return words;
        }
    }
}
