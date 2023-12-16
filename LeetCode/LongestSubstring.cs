using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LongestSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
            int result = 0;
            Dictionary<char,int> keyValuePairs = new Dictionary<char,int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (keyValuePairs.ContainsKey(s[i]))
                {
                    //move back to next index of the previously existing char 
                    i = keyValuePairs[s[i]];
                    keyValuePairs.Clear();
                }
                else
                {
                    keyValuePairs.Add(s[i], i);
                    result = Math.Max(result, keyValuePairs.Count);
                }
            }
            return result;

        }

        public int LengthOfLongestSubstring_bestSolution(string s)
        {
            int left = 0, right = 0;
            int maxLength = 0;
            var hashSet = new HashSet<int>();
            while (right < s.Length)
            {
                var currValue = s[right];
                if (hashSet.Contains(currValue))
                {
                    hashSet.Remove(s[left]);
                    left++;
                }
                else
                {
                    hashSet.Add(s[right]);
                    maxLength = Math.Max(maxLength, right - left + 1);
                    right++;
                }
            }
            return maxLength;
        }
    }
}
