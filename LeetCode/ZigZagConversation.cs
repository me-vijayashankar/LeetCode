using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ZigZagConversation
    {
        public string Convert(string s, int numRows)
        {
            Dictionary<int,List<char>> keyValuePairs = new Dictionary<int,List<char>>();
            char[] charArray = s.ToCharArray();
            int start = 0;
            int end = s.Length;
            int count = 0;
            while (true)
            {
                for (int i = 0; i < numRows&& start < end; i++)
                {
                    if (keyValuePairs.ContainsKey(i))
                    {
                        keyValuePairs[i].Add(s[start]);
                    }
                    else
                    {
                        keyValuePairs[i] = new List<char>() { s[start] };
                    }
                    start++;
                    count++;
                }
                if (start >= end)
                {
                    break;
                }
                for (int i = numRows - 2 ; i > 0 && start < end; i--)
                {
                    keyValuePairs[i].Add(s[start]);
                    start++;
                    count++;
                }
                if(start >= end)
                {
                    break;
                }
            }
            string result = string.Empty;
            foreach (var pair in keyValuePairs) {
                result += new string(pair.Value.ToArray());
            }
            Console.WriteLine("count - {0}",count);
            return result;
        }

        // took 
        public string ConvertAlternateApproch(string s, int numRows)
        {
            if (numRows == 1 || s.Length <= 1)
            {
                return s;
            }

            string[] solution = new string[numRows];

            int i = 0, direction = 1;
            foreach (char c in s)
            {
                solution[i] += c;

                i += direction;

                if (i == numRows - 1 || i == 0) direction *= -1;
            }

            return string.Concat(solution);
        }
    }
}
