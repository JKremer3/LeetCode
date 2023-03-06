namespace ModerateLC
{
    public static class removeNthNodeFromList
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var startNode = new ListNode(0);
            var laggingNode = startNode;
            var leadingNode = startNode;
            
            laggingNode.next = head;

            //Move leading node N spaces in front of the lagging node
            for (int i = 0; i <= n; i++)
                leadingNode = leadingNode.next;

            //Progress both leading and lagging node through the list, until the lead node reaches the end of the list
            while (leadingNode != null)
            {
                laggingNode = laggingNode.next;
                leadingNode = leadingNode.next;
            }

            //skip the node to be removed, then return
            laggingNode.next = laggingNode.next.next;
            return startNode.next;
        }
    }
}