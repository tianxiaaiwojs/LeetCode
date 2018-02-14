using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallProject
{
    public class AddTwoNumbersSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            //var returnListNode = new ListNode();
            var nextNode = l1.next;
            var l1String = string.Empty;
            l1String += l1.val.ToString();
            while (nextNode != null)
            {
                l1String += nextNode.val.ToString();
                nextNode = nextNode.next;
            }

            //L2
            nextNode = l2.next;
            var l2String = string.Empty;
            l2String += l2.val.ToString();
            while (nextNode != null)
            {
                l2String += nextNode.val.ToString();
                nextNode = nextNode.next;
            }

            //var sum = long.Parse(ReverseString(l1String)) + long.Parse(ReverseString(l2String));

            List<int> sum = new List<int>();
            if (l1String.Length > l2String.Length)
            {
                sum = this.AddTwoReverseNumber(l1String.ToCharArray(), l2String.ToCharArray());
            }
            else
            {
                sum = this.AddTwoReverseNumber(l2String.ToCharArray(), l1String.ToCharArray());
            }

            ListNode currentNode = null;
            for (int i = sum.Count -1; i >=0; i--)
            {
                var newNode = new ListNode(int.Parse(sum[i].ToString()));
                newNode.next = currentNode;
                currentNode = newNode;
            }
            return currentNode;
        }

        private string ReverseString(string str)
        {
            var chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        private List<int> AddTwoReverseNumber(char[] longerOne, char[] shorterOne)
        {
            List<int> sum = new List<int>();
            bool needAddOne = false;
            for (int i = 0; i < longerOne.Count(); i++)
            {
                var currentElement = int.Parse(longerOne[i].ToString());
                if (shorterOne.Count() - 1 >= i)
                {
                    currentElement += int.Parse(shorterOne[i].ToString());
                }

                if (needAddOne)
                {
                    currentElement += 1;
                    needAddOne = false;
                }
                if (currentElement >= 10)
                {
                    sum.Add(currentElement % 10);
                    needAddOne = true;
                }
                else
                {
                    sum.Add(currentElement);
                }
            }
            if (needAddOne)
            {
                sum.Add(1);
            }
            return sum;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        private string p;
        public ListNode(int x) { val = x; }
    }
}
