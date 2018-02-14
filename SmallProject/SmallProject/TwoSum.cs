using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallProject
{
    /// <summary>
    /// LeetCode problem 1 Two Sum.
    /// </summary>
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] returnInt = new int[2];
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Count(); i++)
            {
                if (map.ContainsKey(target - nums[i]))
                {
                    returnInt[0] = map[target - nums[i]];
                    returnInt[1] = i;
                    break;
                }
                //already exist
                if (!map.ContainsKey(nums[i]))
                {
                    map.Add(nums[i], i);    
                }
                
            }
            return returnInt;
        }
    }
}
