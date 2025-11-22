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
        ListNode newList = new ListNode(-1);
        ListNode pointer = newList;
        List<ListNode> reverseList = new List<ListNode>();
        int counter = 1;

        while(counter < left){
            pointer.next = head;    // starts assigning 1, counter ends in 1
            pointer = pointer.next;
            
            head = head.next;
            counter++;
        }

        while(counter <= right){
            // hacemos pares visitando head
            reverseList.Add(head);

            head = head.next;
            counter++;
        }

        //cambiamos los pares a pointer
        for (int i = reverseList.Count - 1; i >= 0; i--)
        {
            reverseList[i].next = null;
            pointer.next = reverseList[i];
            pointer = pointer.next;
        }



        // añadimos lo último tras right (si queda)
        while(head != null){
            pointer.next = head;
            pointer = pointer.next;
            
            head = head.next;
        }


        return newList.next;
    }
}