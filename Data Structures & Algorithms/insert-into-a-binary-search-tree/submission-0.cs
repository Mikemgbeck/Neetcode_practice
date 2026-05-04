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
    public TreeNode InsertIntoBST(TreeNode root, int val) 
    {
        //recursivley traverse the tree
        if (root == null) 
        {
            return new TreeNode(val);
        }
        // go down the right or left nodes depending on the value 
        if (val > root.val) 
        {
            root.right = InsertIntoBST(root.right, val);
        } else 
        {
            root.left = InsertIntoBST(root.left, val);
        }
        // finally return the root 
        return root;

    }
}