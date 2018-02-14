using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallProject
{
    public class LongestPalindromeSolution
    {
        public string LongestPalindrome(string s)
        {
            var returnString = string.Empty;
            //maxCount include all.
            var maxCount = 0;
            var duplicateChar = string.Empty;
            //int[] is double array, and first ele is first index, second ele is last index.
            var currentMap = new Dictionary<string, int[]>();
            var chars = s.ToCharArray();
            for (int i = 0; i < chars.Count(); i++)
            {
                
            }

            return returnString;
        }
    }
}
