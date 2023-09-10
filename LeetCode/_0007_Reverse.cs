namespace LeetCode;

public class _0007_Reverse
{
    // 注意推导出返回零的条件的不等式的证明
    public int Reverse(int x)
    {
        var reverse = 0;

        while (x != 0)
        {
            if (reverse is < int.MinValue / 10 or > int.MaxValue / 10)
            {
                return 0;
            }

            var digit = x % 10;
            reverse = reverse * 10 + digit;

            x /= 10;
        }

        return reverse;
    }

    // 重点在于2^31和2^31-1最大位为2，也就是说如果数字小于10位时不用去考虑越界问题。
    // 等于10位时，只用比较反转后的数字reverse前9位与最大最小值的前9位即可。
    // 因为输入数字为10位时，最高位不可能超过2，就是说反转之后reverse的最低位最大为2，不可能超过7;
    // 所以前9位不超过最大最小值前9位时，第10位（最低位）不存在超过最大最小值最低位的情况，也就自然不用关注最低位了。
    public int Reverse_2(int x)
    {
        var result     = 0;
        var isNegative = x < 0;

        if (isNegative)
        {
            x = -x;
        }

        while (x != 0)
        {
            if (result is > int.MaxValue / 10 or < int.MinValue / 10)
            {
                return 0;
            }

            var remainders = x % 10;
            var quotient   = x / 10;

            result = result * 10 + remainders;

            x = quotient;
        }

        if (isNegative)
        {
            result = -result;
        }

        return result;
    }
}
