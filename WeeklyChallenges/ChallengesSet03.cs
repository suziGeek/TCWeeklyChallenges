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
            throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()
        {
            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            string myWords = words.ToString();
           var yourWords =  myWords.ToUpper();
            return yourWords;
        }
    }
}
