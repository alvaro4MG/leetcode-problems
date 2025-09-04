// 21. Merge Two Sorted Lists

// You are given the heads of two sorted linked lists list1 and list2.
// Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.
// Return the head of the merged linked list.

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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode newList = new ListNode(-1);
        ListNode pointer = newList;

        while( (list1 != null ) && (list2 != null ) ){

            if(list1 != null){
                if(list2.val > list1.val){
                    pointer.next = list1;
                    list1 = list1.next;
                }else{
                    pointer.next = list2;
                    list2 = list2.next;
                }
            }

            pointer = pointer.next;
        }

        if(list1 != null){
            pointer.next = list1;
        }else{
            pointer.next = list2;
        }

        return newList.next;
    }
}