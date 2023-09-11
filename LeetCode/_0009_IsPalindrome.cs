namespace LeetCode;

public class _0009_IsPalindrome
{
    // 依靠语言特性更优的方法是直接反转，如果溢出导致反转与原数不一致，则一定不是回文数
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        var m   = (long)x;
        var rev = (long)0;

        while (m != 0)
        {
            rev =  rev * 10 + m % 10;
            m   /= 10;
        }

        return rev == x;
    }
}
