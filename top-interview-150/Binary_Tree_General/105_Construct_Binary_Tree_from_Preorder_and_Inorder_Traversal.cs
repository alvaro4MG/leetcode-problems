// 105. Construct Binary Tree from Preorder and Inorder Traversal

// Given two integer arrays preorder and inorder where preorder is the preorder traversal of a binary tree and inorder is the inorder traversal of the same tree, construct and return the binary tree.

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

    private Dictionary<int, int> inorderIndex = new Dictionary<int, int>();

    private TreeNode BuildRecursive(int[] preorder, int[] inorder, int inLeft, int inRight, ref int preIndex){
        
        if (inLeft > inRight){
            return null;
        } 

        int rootVal = preorder[preIndex++];
        TreeNode root = new TreeNode(rootVal);

        int idx = inorderIndex[rootVal];

        root.left = BuildRecursive(preorder, inorder, inLeft, idx - 1, ref preIndex);
        root.right = BuildRecursive(preorder, inorder, idx + 1, inRight, ref preIndex);

        return root;
    }

    public TreeNode BuildTree(int[] preorder, int[] inorder) {

        for(int i = 0; i < inorder.Length; i++){
            inorderIndex.Add(inorder[i], i);
        }

        int firstIndex = 0;

        return BuildRecursive(preorder, inorder, 0, inorder.Length - 1, ref firstIndex);
    }
}