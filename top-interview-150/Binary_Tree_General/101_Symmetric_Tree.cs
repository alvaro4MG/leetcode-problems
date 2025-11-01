// 101. Symmetric Tree

// Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).

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

    private bool AreSymmetric(TreeNode right, TreeNode left){

        if(right == null){
            return (left == null);
        }else{
            if(left == null){
                return false;
            }
            if(right.val != left.val){
                return false;
            }
        }
        return AreSymmetric(right.right,left.left) && AreSymmetric(right.left,left.right);
    }

    public bool IsSymmetric(TreeNode root) {
        
        return AreSymmetric(root.right, root.left);
    }
}