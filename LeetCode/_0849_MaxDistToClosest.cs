namespace LeetCode;

public class _0849_MaxDistToClosest
{
    public int MaxDistToClosest(int[] seats)
    {
        var maxDist = 0;

        var len = seats.Length;

        // 左指针为未移动的状态时, 记作特殊值
        var left  = int.MinValue;
        var right = 0;

        while (right < len)
        {
            if (seats[right] == 1)
            {
                // 如果左指针已移动, 取 [left, right] 中位数
                // 否则, 最长距离为数组最左端到右指针的距离, 取 [0, right) 的长度
                var dist = left != int.MinValue ? (right - left) >> 1 : right - 0;

                maxDist = Math.Max(dist, maxDist);

                // 左指针移动至右指针位置
                left = right;
            }

            right++;
        }

        // 如果尾部为零, 则仍有 (left, len - 1] 需要计入
        if (seats[len - 1] == 0)
        {
            var dist = len - 1 - left;

            maxDist = Math.Max(dist, maxDist);
        }

        return maxDist;
    }

    // 0, 0, 0, 0, 1
    // 1, 0, 0, 0, 0
    // 1, 0, 0, 1, 0, 1
    // 1, 0, 0, 0, 1, 0, 1
    // 0, 1, 0, 0, 0, 1, 0, 1
    // 0, 1, 0, 0, 1, 0, 1
    public int MaxDistToClosest_2(int[] seats)
    {
        var maxDist = 0;

        var left  = -1;
        var right = 0;

        var len = seats.Length;

        while (right < len)
        {
            if (seats[right] == 1)
            {
                int dist;

                if (left != -1)
                {
                    dist = (right - left) >> 1;
                }
                else
                {
                    dist = right;
                }

                if (dist > maxDist)
                {
                    maxDist = dist;
                }

                left = right;
            }

            right++;
        }

        if (seats[len - 1] == 0)
        {
            var dist = len - 1 - left;
            if (dist > maxDist)
            {
                maxDist = dist;
            }
        }

        return maxDist;
    }
}
