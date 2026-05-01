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
 
public class Solution {
    public ListNode ReverseList(ListNode head) 
    {
        if (head == null) 
        {
            return null; // If the list is empty, return null
        }
        ListNode prev = null;
        ListNode current = head;

        while (current != null) 
        {
            ListNode nextTemp = current.next; // Store the next node
            current.next = prev; // Reverse the current node's pointer
            prev = current; // Move prev to the current node
            current = nextTemp; // Move to the next node
        }

        return prev; // At the end, prev will be the new head of the reversed list
        
        
    }
}
