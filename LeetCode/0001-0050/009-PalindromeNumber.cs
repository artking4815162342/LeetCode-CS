//-----------------------------------------------------------------------------
// Runtime: 43ms
// Memory Usage: 30.2 MB
// Link: https://leetcode.com/submissions/detail/351897898/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _009_PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            var str = x.ToString();
            for (var i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}