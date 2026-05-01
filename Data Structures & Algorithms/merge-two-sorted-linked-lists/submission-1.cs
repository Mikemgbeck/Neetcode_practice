/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution 
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        ListNode dummy = new ListNode(0);
        ListNode node = dummy;
        //make sure we havent reached the end of either
        while (list1 != null && list2 != null)
        {
            //compare the values of the current node
            if (list1.val < list2.val)
            {
                //list 1 smaller
                //set dummy node
                node.next = list1;
                // iterate list 1
                list1 = list1.next;
            } else
            {
                //list 2 smaller or equal
                node.next = list2;
                list2 = list2.next;
            }
            node = node.next;
        }
        //we came out of the loop so list one or 2 hit null
        if (list1 != null)
        {
            //attach any remaining nodes to our new list
            node.next = list1;
        } else 
        {
            node.next = list2;
        }
    return dummy.next;
        
    }
}