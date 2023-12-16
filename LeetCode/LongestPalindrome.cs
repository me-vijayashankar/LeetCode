
namespace LeetCode
{
    public class LongestPalindrome
    {
        public string GetLongestPalindrome(string s)
        {
            if(s.Length == 0)
            {
                return s;
            }
            List<char> l = new List<char>();
            Dictionary<int,List<char>> dic = new Dictionary<int,List<char>>();
            for (int i = 0; i < s.Length; i++)
            {
                l.Clear();
                l.Add(s[i]);
                for (int j = i+1; j < s.Length; j++)
                {
                    l.Add(s[j]);
                    if(isPalindrome(l))
                    {
                        dic[l.Count]= new List<char>(l);
                    }
                    
                }
            }
            if(dic.Count > 0)
            {
                return new string(dic[dic.Keys.Max()].ToArray());
            }
            else
            {
                return s[0].ToString();
            }
        }
        public bool isPalindrome(List<char> s)
        {
            var halfLength = s.Count / 2;
            var length = s.Count;
            for (int i = 0;i <= halfLength;i++) {
                if (s[i] != s[length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
