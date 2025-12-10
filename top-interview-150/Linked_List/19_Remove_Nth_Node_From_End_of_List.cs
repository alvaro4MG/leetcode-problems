// 19. Remove Nth Node From End of List

// Given the head of a linked list, remove the nth node from the end of the list and return its head.

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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode pointer = head;
        int i = 1;
        Dictionary<int, ListNode> positions = new Dictionary<int, ListNode>();

        while(head != null){
            positions.Add(i, head);

            head = head.next;
            i++;
        }


        int nth = positions.Count - n;

        if(nth > 0){
            if(nth + 2 <= positions.Count){
                positions[nth].next = positions[nth+2];
            }else{
                positions[nth].next = null;
            }
        }else{
            if(positions.Count > 1){
                pointer = positions[2];
            }else{
                return null;
            }
        }

        return pointer;
        
    }
}