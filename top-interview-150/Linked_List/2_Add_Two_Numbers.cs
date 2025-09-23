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
        int number1 = 0;
        int size1 = 0;
        int number2 = 0;
        int size2 = 0;
        bool plusOne = false;
        int sum;

        ListNode newList = new ListNode(-1);
        ListNode pointer = newList;

        while(l1 != null){
            number1 += l1.val * (int)Math.Pow(10, size1);
            size1++;
            l1 = l1.next;
        }
        while(l2 != null){
            number2 += l2.val * (int)Math.Pow(10, size2);
            size2++;
            l2 = l2.next;
        }

        for(int i = 0; i < size1 || i < size2 || plusOne; i++){
            sum = number1%10 + number2%10;

            if(plusOne){
                sum++;
            }

            if(sum > 9){
                pointer.next = new ListNode( sum % 10 );
                plusOne = true;
            }else{
                pointer.next = new ListNode(sum);
                plusOne = false;
            }
            pointer = pointer.next;

            number1 = number1 / 10;
            number2 = number2 / 10;
        }

        return newList.next;

    }
}