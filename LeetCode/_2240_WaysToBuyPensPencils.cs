namespace LeetCode;

public class _2240_WaysToBuyPensPencils
{
    // 注意max1上下界都为闭区间（可以买[0, max1]个）
    public long WaysToBuyPensPencils(int total, int cost1, int cost2)
    {
        long ans = 0;

        var max1 = total / cost1;

        for (var i = 0; i <= max1; i++)
        {
            var left = total - cost1 * i;
            var max2 = left / cost2;

            ans += max2 + 1;
        }

        return ans;
    }
}
