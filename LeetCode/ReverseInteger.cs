using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            bool negative = x >= 0 ? false : true;
            int input = negative ? x*-1 : x;
            int result = 0;
            var prev = 0;
            while (input > 0)
            {
                prev = result;
                var temp = input % 10;
                result = result *10 + temp;
                input = input / 10;
            }
            if (result / 10 != prev)
                return 0;
            return negative? result*-1: result;
        }
    }
}
