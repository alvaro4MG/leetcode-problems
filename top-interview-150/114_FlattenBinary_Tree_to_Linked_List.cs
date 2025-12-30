// 114. Flatten Binary Tree to Linked List

// Given the root of a binary tree, flatten the tree into a "linked list":
    // The "linked list" should use the same TreeNode class where the right child pointer points to the next node in the list and the left child pointer is always null.
    // The "linked list" should be in the same order as a pre-order traversal of the binary tree.

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
    public void Flatten(TreeNode root) {
        Stack<TreeNode> stack = new Stack<TreeNode>();

        while(root != null){
            if(root.right != null){
                stack.Push(root.right);
            }

            if(root.left != null){
                root.right = root.left;
                root.left = null;
            }else{
                TreeNode aux = stack.Pop();
                root.right = aux;
            }
            root = root.right;
            
        }

    }
}