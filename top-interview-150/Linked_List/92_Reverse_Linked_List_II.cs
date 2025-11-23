// 92. Reverse Linked List II

// Given the head of a singly linked list and two integers left and right where left <= right, reverse the nodes of the list from position left to position right, and return the reversed list.

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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        ListNode newList = new ListNode(-1, head);
        ListNode pointer = newList;
        int counter = 1;

        if (head == null || head.next == null || left == right)
            return head;
        

        while(counter < left){
            pointer = pointer.next;
            
            head = head.next;
            counter++;
        }
        
        
        ListNode beforeLeft = pointer;
        ListNode first = head;
        ListNode aux = head.next;


        while(counter < right && aux != null){
            first.next = aux.next;
            aux.next = beforeLeft.next;
            beforeLeft.next = aux;


            aux = first.next;
            counter++;
        }


        return newList.next;
    }
}