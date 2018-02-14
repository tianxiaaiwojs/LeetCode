using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallProject
{
    public class LongestSubString
    {
        public int LengthOfLongestSubstring(string s)
        {
            //<string, index>
            //var longestMap = new Dictionary<string, int>();
            var maxCount = 0;
            var currentMap = new Dictionary<string, int>();
            var chars = s.ToCharArray();
            for (int i = 0; i < chars.Count(); i++)
            {
                if (currentMap.ContainsKey(chars[i].ToString()))
                {
                    if (currentMap.Count > maxCount)
                    {
                        maxCount = currentMap.Count;
                    }
                    //remove non-use part.
                    foreach (var item in currentMap.Where(x => x.Value <= currentMap[chars[i].ToString()]).ToList())
                    {
                        currentMap.Remove(item.Key);
                    }
                }
                //still need to add current elememnt.
                currentMap.Add(chars[i].ToString(), i);
            }
            if (currentMap.Count > maxCount)
            {
                maxCount = currentMap.Count;
            }

            return maxCount;
        }
    }
}
