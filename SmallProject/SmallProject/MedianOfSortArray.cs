using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallProject
{
    public class MedianOfSortArray
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var final = this.Merge(nums1, nums2);
            double midNumber = (double)final.Count() / 2;
            if (midNumber == Math.Floor(midNumber))
            {
                int index = (int)Math.Floor(midNumber) - 1;
                return (double)(final[index] + final[index + 1]) / 2;
            }
            else
            {
                return (double)(final[(int)Math.Floor(midNumber)]);
            }
        }

        private int[] Merge(int[] nums1, int[] nums2)
        {
            int[] final = new int[nums1.Count() + nums2.Count()];
            var index1 = 0;
            var index2 = 0;
            var index = 0;
            while (index1 < nums1.Count() && index2 < nums2.Count())
            {
                if (nums1[index1] < nums2[index2])
                {
                    final[index] = nums1[index1];
                    index1++;
                }
                else
                {
                    final[index] = nums2[index2];
                    index2++;
                }

                index++;
            }

            for (var i = index1; i < nums1.Count(); i++, index++)
            {
                final[index] = nums1[i];
            }
            for (var i = index2; i < nums2.Count(); i++, index++)
            {
                final[index] = nums2[i];
            }

            return final;
        }
    }
}
