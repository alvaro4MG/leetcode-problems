// 530. Minimum Absolute Difference in BST

// Given the root of a Binary Search Tree (BST), return the minimum absolute difference between the values of any two different nodes in the tree.

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int GetMinimumDifference(TreeNode root) {
        int minDiff = int.MaxValue;
        int? previous = null;
        

        if(root == null){
            return 0;
        }

        Stack<TreeNode> stack = new Stack<TreeNode>();
        //stack.Push(root);
        TreeNode pointer = root;

        while(pointer != null || stack.Count > 0) {
            
            while(pointer != null){
                stack.Push(pointer);
                pointer = pointer.left;
            }
            
            pointer = stack.Pop();

            if(previous.HasValue){
                minDiff = Math.Min(minDiff, pointer.val - previous.Value);
            }
            previous = pointer.val;

            pointer = pointer.right;
            
        }

        return minDiff;
    }
}