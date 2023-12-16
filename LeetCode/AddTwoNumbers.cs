using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class AddTwoNumbers
    {
        public ListNode AddTwoNumbersListNode(ListNode l1, ListNode l2)
        {
            long one = 0;
            long two = 0;
            while (l1 != null)
            {
                one = one * 10 + l1.val;
                l1 = l1.next;
            }
            while (l2 != null)
            {
                two = two * 10 + l2.val;
                l2 = l2.next;
            }
            long three = one + two;

            ListNode result = null;
            ListNode prev = null;

            do
            {
                var n = new ListNode((int)three % 10);
                if (result != null)
                {
                    prev.next = n;
                }
                else
                {
                    result = n;
                }
                prev = n;
                three = three / 10;
            } while (three > 0);
            return result;
        }

        //Console.WriteLine(convertIntoList(243));

        public ListNode convertIntoList(int[] input)
        {
            //List<int> ilist = new List<int>();
            //while (inputnum > 0)
            //{
            //    var q = inputnum % 10;
            //    ilist.Add(q);
            //    inputnum = inputnum / 10;
            //}
            ListNode listNode = null;
            ListNode prev = null;
            //var input = ilist.ToArray();
            foreach (var i in input)
            {
                var node = new ListNode(i);
                if (listNode != null)
                {
                    prev.next = node;
                }
                else
                {
                    listNode = node;
                }
                prev = node;
            }
            return listNode;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
