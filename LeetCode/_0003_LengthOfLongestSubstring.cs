namespace LeetCode;

public class _0003_LengthOfLongestSubstring
{
    // 根据滑动窗口算法，进一步简化为单循环
    public int LengthOfLongestSubstring(string s)
    {
        var chars = new HashSet<char>();

        var left    = 0;
        var right   = 0;
        var len     = s.Length;
        var count   = 0;
        var longest = 0;

        while (right < len)
        {
            if (!chars.Contains(s[right]))
            {
                chars.Add(s[right]);
                count++;
                right++;
            }
            else
            {
                chars.Remove(s[left]);
                count--;
                left++;
            }

            if (count > longest)
            {
                longest = count;
            }
        }

        return longest;
    }

    // 滑动窗口算法（Sliding Window）可以用来解决字符串（数组）的子元素问题，，查找满足一定条件的连续子区间，可以将嵌套的循环问题，转化为单循环问题，降低时间复杂度。
    public int LengthOfLongestSubstring_3(string s)
    {
        // pwwkew
        // acbafghijk

        var longest = 0;

        var left  = 0;
        var right = 0;
        var len   = s.Length;

        if (len == 1)
        {
            return 1;
        }

        var indexesByChars = new Dictionary<char, int>();

        while (left < len)
        {
            var isBreak = false;

            while (right < len)
            {
                if (indexesByChars.TryGetValue(s[right], out var index))
                {
                    if (right - left > longest)
                    {
                        longest = right - left;
                    }

                    while (left < index)
                    {
                        indexesByChars.Remove(s[left]);
                        left++;
                    }

                    indexesByChars[s[right]] = right;
                    right++;

                    isBreak = true;

                    break;
                }

                indexesByChars.Add(s[right], right);
                right++;
            }

            if (!isBreak)
            {
                if (right - left > longest)
                {
                    longest = right - left;
                }
            }

            left++;
        }

        return longest;
    }

    public int LengthOfLongestSubstring_2(string s)
    {
        // abcabcbb
        // abcdefa
        // abcabcabca
        // acbafghijkcbabca
        // iiabcdefg
        // pwwkew

        var longest = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var indexesByChars = new Dictionary<char, int>();
            var currLongest    = 0;

            for (var j = i; j < s.Length; j++)
            {
                if (indexesByChars.ContainsKey(s[j]))
                {
                    if (j - i > longest)
                    {
                        longest = j - i;
                    }

                    i = indexesByChars[s[j]];

                    break;
                }

                currLongest++;
                indexesByChars.TryAdd(s[j], j);
            }

            if (currLongest > longest)
            {
                return currLongest;
            }
        }

        return longest;
    }
}
