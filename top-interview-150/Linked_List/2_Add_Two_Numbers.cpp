// 2. Add Two Numbers

// You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
// You may assume the two numbers do not contain any leading zero, except the number 0 itself.

/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
class Solution {
public:
    ListNode* addTwoNumbers(ListNode* l1, ListNode* l2) {
        ListNode list = ListNode(-1);
        ListNode* head = &list;
        bool plusOne = false;

        while(plusOne || (l1 != nullptr || l2 != nullptr) ){
            int result = 0;

            if(l1 != nullptr){
                result += l1->val;
                l1 = l1->next;
            }

            if(l2 != nullptr){
                result += l2->val;
                l2 = l2->next;
            }

            if(plusOne){
                result++;
            }

            if(result > 9){
                plusOne = true;
                result = result % 10;
            }else{
                plusOne = false;
            }

            ListNode* following = new ListNode(result);
            head->next = following;
            head = head->next;

        }

        return list.next;

    }
};