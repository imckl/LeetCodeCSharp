namespace LeetCode;

public class _0069_MySqrt
{
    public int MySqrt(int x)
    {
        if (x == 1)
        {
            return 1;
        }

        var left  = 0;
        var right = x;

        while (left < right - 1)
        {
            var mid = (right + left) >> 1;

            var powMid = (long)mid * mid;

            if (x < powMid)
            {
                right = mid;
            }
            else if (x > powMid)
            {
                left = mid;
            }
            else
            {
                return mid;
            }
        }

        return left;
    }
}
