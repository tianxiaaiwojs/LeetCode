using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallProject
{
    class Program
    {
        static void Main(string[] args)
        {
            LongestPalindrome();
            Console.Read();
        }

        #region TwoSum
        static void TwoSum()
        {
            var twoSum = new TwoSumSolution();
            var arr = twoSum.TwoSum(new int[3] { 3,2,4 }, 6);
            Console.WriteLine(string.Format("{0}, {1}", arr[0], arr[1]));
            Console.Read();
        }
        #endregion

        #region AddTwoNumbers
        static void AddTwoNumbers(){
            var l1 = new ListNode(9);

            var l2 = new ListNode(1);
            l2.next = new ListNode(9);
            l2.next.next = new ListNode(9);
            l2.next.next.next = new ListNode(9);
            l2.next.next.next.next = new ListNode(9);
            l2.next.next.next.next.next = new ListNode(9);
            l2.next.next.next.next.next.next = new ListNode(9);
            l2.next.next.next.next.next.next.next = new ListNode(9);
            l2.next.next.next.next.next.next.next.next = new ListNode(9);
            l2.next.next.next.next.next.next.next.next.next = new ListNode(9);

            var solutions = new AddTwoNumbersSolution();
            var sum = solutions.AddTwoNumbers(l1, l2);

            var printString = sum.val.ToString();
            var nextNode = sum.next;
            while(nextNode != null){
                printString += nextNode.val.ToString();
                nextNode = nextNode.next;
            }

            Console.WriteLine(printString);
            Console.Read();
        }
        #endregion

        #region LongestString
        static void LongestSubString()
        {
            var solution = new LongestSubString();
            var count = solution.LengthOfLongestSubstring("aab");

            Console.WriteLine(count);
            Console.Read();
        }
        #endregion

        #region MedianOfSortArray
        static void MedianOfSortArray()
        {
            var solution = new MedianOfSortArray();
            var count = solution.FindMedianSortedArrays(new int[] {1,3 }, new int[] {2 });

            Console.WriteLine(count);
            Console.Read();
        }
        #endregion

        #region MyRegion
        static void LongestPalindrome()
        {
            var solutions = new LongestPalindromeSolution();
            var returnString = solutions.LongestPalindrome("abcda");

            Console.WriteLine(returnString);
            
        }
        #endregion

        #region DoubleAndBrowser
        static void DoubleAndBrowser()
        {
            //double value = 1.5;
            //var xx = Console.ReadLine();
            //while (!string.IsNullOrEmpty(xx))
            //{
            //    Console.WriteLine(Math.Round(double.Parse(xx)));
            //    xx = Console.ReadLine();
            //}

            //Console.Read();

            System.Diagnostics.Process.Start("iexplore", "-k " + "http://www.google.co.uk");
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe", "--chrome-frame -kiosk " + "http://www.google.co.uk");
        }
        #endregion
        
    }
}
