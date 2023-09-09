using LeetCode.Structs;

namespace LeetCode;

public class _0002_AddTwoNumbers
{
    // 注意进位; 链表指针替换; null值检测
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var carry  = 0;
        var sumVal = l1.val + l2.val;
        var newVal = sumVal % 10;

        var head = new ListNode(newVal);
        var tail = head;

        carry = sumVal >= 10 ? 1 : 0;

        while (l1.next is not null && l2.next is not null)
        {
            l1 = l1.next;
            l2 = l2.next;

            sumVal = l1.val + l2.val + carry;
            newVal = sumVal % 10;

            tail.next = new ListNode(newVal);
            tail      = tail.next;

            carry = sumVal >= 10 ? 1 : 0;
        }

        while (l1.next is not null)
        {
            l1 = l1.next;

            sumVal = l1.val + carry;
            newVal = sumVal % 10;

            tail.next = new ListNode(newVal);
            tail      = tail.next;

            carry = sumVal >= 10 ? 1 : 0;
        }

        while (l2.next is not null)
        {
            l2 = l2.next;

            sumVal = l2.val + carry;
            newVal = sumVal % 10;

            tail.next = new ListNode(newVal);
            tail      = tail.next;

            carry = sumVal >= 10 ? 1 : 0;
        }

        if (carry == 1)
        {
            tail.next = new ListNode(1);
        }

        return head;
    }
}
