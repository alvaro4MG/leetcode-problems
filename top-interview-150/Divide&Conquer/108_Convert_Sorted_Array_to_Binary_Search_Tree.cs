// 108. Convert Sorted Array to Binary Search Tree

// Given an integer array nums where the elements are sorted in ascending order, convert it to a height-balanced binary search tree.

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

    private TreeNode BuildTree(int[] nums, int left, int right) {
        if(left > right){
            return null;
        }

        int mid = (left + right) / 2;

        TreeNode node = new TreeNode(nums[mid]);
        node.left = BuildTree(nums, left, mid - 1);
        node.right = BuildTree(nums, mid + 1, right);

        return node;
    }

    public TreeNode SortedArrayToBST(int[] nums) {
        
        if(nums == null){
            return null;
        }

        return BuildTree(nums, 0, nums.Length-1);

    }
}