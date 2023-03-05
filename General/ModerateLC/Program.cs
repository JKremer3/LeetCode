using System;

namespace ModerateLC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var intList = new int[]{1,2,3,4};
            runRemoveNthNode(intList, 2);
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
    }
}