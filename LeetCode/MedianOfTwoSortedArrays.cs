using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double result = 0;
            List<int> list = new List<int>();
            list.AddRange(nums1);
            list.AddRange(nums2);
            list.Sort();
            int mid = list.Count / 2;
            if (list.Count % 2 != 0)
            {
                result = list[mid];
            }
            else
            {
                result = (double)(list[mid] + list[mid - 1])/2;
            }
            return result;
        }
    }
}
