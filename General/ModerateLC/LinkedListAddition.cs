namespace ModerateLC
{
    public static class LinkedListAddition
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int sum = 0, carry = 0;
            ListNode retList = new ListNode(0);
            ListNode currNode = retList, currL1 = l1, currL2 = l2;
            
            while (currL1 != null || currL2 != null)
            {
                if (currL1 != null)
                {
                    sum += currL1.val;
                    currL1 = currL1.next;
                }

                if (currL2 != null)
                {
                    sum += currL2.val;
                    currL2 = currL2.next;
                }

                if (carry == 1)
                {
                    sum += carry;
                    carry = 0;
                }

                if (sum >= 10)
                {
                    carry = 1;
                    sum -= 10;
                }

                currNode.next = new ListNode(sum);
                currNode = currNode.next;
                sum = 0;
            }

            if (carry > 0)
            {
                currNode.next = new ListNode(carry);
            }
            
            return retList.next;
        }
    }
}