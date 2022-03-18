using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HKingPalindrome.Models
{
    public class Palindrome
    {
        [DisplayName("Enter a positive number to see if it is a Palindrome")]
        public string Number { get; set; }

        [DisplayName("Palindrome:")]
        public bool IsPalindrome { get; set; }

        public Palindrome()
        {

        }

        public Palindrome(string num)
        {
            Number = num;
        }

        public bool IsInputPalindrome(string number)
        {
            for (int i = 0; i < number.Length / 2; i++) //only need to loop half the length
                //compare first and last char, if != return false
                if (number[i] != number[number.Length - 1 - i]) return false;
            return true;
        }
    }
}
