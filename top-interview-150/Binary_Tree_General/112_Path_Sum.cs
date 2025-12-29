// 112. Path Sum

// Given the root of a binary tree and an integer targetSum, return true if the tree has a root-to-leaf path such that adding up all the values along the path equals targetSum.
// A leaf is a node with no children.

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

    private bool RecursivePath(TreeNode root, int targetSum, int sum){

        if(root == null){
            return false;
        }

        sum += root.val;
        if(sum == targetSum){
            if(root.right == null && root.left == null){
                return true;
            }
        }
        return RecursivePath(root.left, targetSum, sum) || RecursivePath(root.right, targetSum, sum);

    }

    public bool HasPathSum(TreeNode root, int targetSum) {
        

        return RecursivePath(root, targetSum, 0);

        /*if(root == null){
            return false;
        }
        
        int sum = 0;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode pointer = root;

        stack.Push(pointer);

        while(stack.Count > 0){
            pointer = stack.Pop();

            sum += pointer.val;

            if(sum == targetSum){
                return true;
            }
            //root = root.right;
            if(pointer.right != null){
                stack.Push(pointer.right);
            }
            if(pointer.left != null){
                stack.Push(pointer.left);
            }
        }*/

        //return false;
    }
}