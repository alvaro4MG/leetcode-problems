// 104. Maximum Depth of Binary Tree

// Given the root of a binary tree, return its maximum depth.
// A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.

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

    private int MaxDepthNode(TreeNode node){
        
        if(node == null){
            return 0;
        }

        return 1 + Math.Max(MaxDepthNode(node.left), MaxDepthNode(node.right));

    }

    public int MaxDepth(TreeNode root) {
        /*int depth = 0;

        if(root == null){
            return depth;
        }

        depth = 1 + Math.Max(MaxDepthNode(root.left), MaxDepthNode(root.right));*/


        return MaxDepthNode(root);
    }
}