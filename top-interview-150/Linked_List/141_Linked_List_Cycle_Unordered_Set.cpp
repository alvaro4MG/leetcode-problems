// 141. Linked List Cycle

// Given head, the head of a linked list, determine if the linked list has a cycle in it.
// There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer. Internally, pos is used to denote the index of the node that tail's next pointer is connected to. Note that pos is not passed as a parameter.
// Return true if there is a cycle in the linked list. Otherwise, return false.

// SOLUTION USING unordered_set, NOT OPTIMAL

/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
class Solution {
private:
    unordered_set<ListNode*> visited;
public:
    bool hasCycle(ListNode *head) {
        
        while(head != nullptr){
            if(visited.count(head)){
                return true;
            }
            visited.insert(head);
            
            head = head-> next;
        }

        return false;
    }
};