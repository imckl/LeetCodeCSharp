namespace LeetCode;

public class _0027_RemoveElement
{
    public int RemoveElement_Optimize(int[] nums, int val)
    {
        var left  = 0;
        var right = nums.Length;

        while (left < right)
        {
            if (nums[left] == val)
            {
                nums[left] = nums[right - 1];
                right--;
            }
            else
            {
                left++;
            }
        }

        return left;
    }

    public int RemoveElement(int[] nums, int val)
    {
        var left  = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            if (nums[left] == val)
            {
                nums[left]  = nums[right];
                nums[right] = val;

                right--;

                if (nums[left] == val)
                {
                    continue;
                }
            }

            left++;
        }

        var length = 0;

        foreach (var num in nums)
        {
            if (num != val)
            {
                length++;
            }
            else
            {
                break;
            }
        }

        return length;
    }

    // public int RemoveElement(int[] nums, int val)
    // {
    //     var last = nums.Length;
    //
    //     var length = 0;
    //
    //     var i = 0;
    //     
    //     while (i < last)
    //     {
    //         if (nums[i] == val)
    //         {
    //             while (last > i && nums[last - 1] == val)
    //             {
    //                 last--;
    //             }
    //             
    //             if (last == i)
    //             {
    //                 return i;
    //             }
    //
    //             nums[i] = nums[last - 1];
    //
    //             nums[last - 1] = val;
    //
    //             last--;
    //
    //             length++;
    //         }
    //
    //         i++;
    //     }
    //
    //     return length;
    // }
}
