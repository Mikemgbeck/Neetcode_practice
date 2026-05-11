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
public class Solution 
{
    public TreeNode DeleteNode(TreeNode root, int key) 
    {
        // Base case: if the tree is empty
        if (root == null) return null;

        // If the key to be deleted is greater than the root's key, then it lies in the right subtree
        if (key > root.val) 
        {
            root.right = DeleteNode(root.right, key);
        // If the key to be deleted is smaller than the root's key, then it lies in the left subtree
        } else if (key < root.val) 
        {
            root.left = DeleteNode(root.left, key);
        // If key is same as root's key, then this is the node to be deleted
        } else 
        {
            // Node with only one child or no child
            if (root.left == null) return root.right;
            // Node with only one child or no child
            if (root.right == null) return root.left;

            // Node with two children: Get the inorder successor (smallest in the right subtree)
            TreeNode cur = root.right;
            // Find the minimum value in the right subtree
            while (cur.left != null) 
            {
                cur = cur.left;
            }
            // Copy the inorder successor's(smallest in the right subtree) content to this node
            root.val = cur.val;
            // Delete the inorder successor
            root.right = DeleteNode(root.right, root.val);
        }
        return root;
    }
}