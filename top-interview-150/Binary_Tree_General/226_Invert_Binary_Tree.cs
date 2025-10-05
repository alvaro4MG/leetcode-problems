// 226. Invert Binary Tree

// Given the root of a binary tree, invert the tree, and return its root.

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
    public TreeNode InvertTree(TreeNode root) {
        
        if(root == null){
            return root;
        }

        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode pointer = root;
        TreeNode aux;

        stack.Push(pointer);

        while(stack.Count > 0){
            pointer = stack.Pop();

            aux = pointer.right;
            pointer.right = pointer.left;
            pointer.left = aux;

            if(pointer.right != null){
                stack.Push(pointer.right);
            }

            if(pointer.left != null){
                stack.Push(pointer.left);
            }
        }

        return root;
    }
}