// 2. Add Two Numbers (Linked List)

// You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
// You may assume the two numbers do not contain any leading zero, except the number 0 itself.

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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        bool plusOne = false;
        int sum = 0;

        ListNode newList = new ListNode(-1);
        ListNode pointer = newList;

        while(l1 != null || l2 != null || plusOne){
            if(l1 != null){
                sum += l1.val;
                l1 = l1.next;
            }
            if(l2 != null){
                sum += l2.val;
                l2 = l2.next;
            }
            if(plusOne){
                sum++;
            }

            if(sum > 9){
                plusOne = true;
                pointer.next = new ListNode(sum%10);
            }else{
                pointer.next = new ListNode(sum);
                plusOne = false;
            }
            
            pointer = pointer.next;
            sum = 0;

        }

        return newList.next;

    }
}