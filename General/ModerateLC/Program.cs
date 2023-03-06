using System;

namespace ModerateLC
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var intList = new int[]{1,2,3,4};
            runRemoveNthNode(intList, 2);
            
            var needle = "a";
            var haystack = "a";
            var needleLoc = NeedleHaystack.NeedleHaystackKMP(needle, haystack);
            //var needleLoc = NeedleHaystack.NeedleHaystackWithStringMethods(needle, haystack);
            Console.WriteLine("Needle " + needle + " in haystack " + haystack + " found at index : " + needleLoc);
            
            var l1 = new int[] {2, 4, 3};
            var l2 = new int[] {5, 6, 4};
            sumNodes(l1, l2);
        }

        static void runRemoveNthNode(int[] nodeList, int n)
        {
            var head = new ListNode(nodeList[0]);
            var curr = head;

            for (int i = 1; i < nodeList.Length; i++)
            {
                var newNode = new ListNode(nodeList[i]);
                curr.next = newNode;
                curr = curr.next;
            }

            var modifiedList = removeNthNodeFromList.RemoveNthFromEnd(head, n);

            if (modifiedList == null)
            {
                Console.WriteLine("[]");
            }
            else
            {
                var outString = "[";
                while (modifiedList != null)
                {
                    outString += modifiedList.val.ToString() + ", ";
                    modifiedList = modifiedList.next;
                }

                outString += "]";
                Console.WriteLine(outString);
            }
        }
        
        static void  sumNodes(int[] l1, int[] l2)
        {
            ListNode headL1 = new ListNode(l1[0]), headL2 = new ListNode(l2[0]);
            ListNode currL1 = headL1, currL2 = headL2;

            for (int i = 1; i < l1.Length; i++)
            {
                var newNode = new ListNode(l1[i]);
                currL1.next = newNode;
                currL1 = currL1.next;
            }
            
            for (int i = 1; i < l2.Length; i++)
            {
                var newNode = new ListNode(l2[i]);
                currL2.next = newNode;
                currL2 = currL2.next;
            }

            var returnList = LinkedListAddition.AddTwoNumbers(headL1, headL2);

            if (returnList == null)
            {
                Console.WriteLine("[]");
            }
            else
            {
                var outString = "[";
                while (returnList != null)
                {
                    outString += returnList.val.ToString() + ", ";
                    returnList = returnList.next;
                }

                outString += "]";
                Console.WriteLine(outString);
            }
        }
    }
}