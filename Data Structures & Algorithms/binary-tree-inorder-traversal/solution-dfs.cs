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
    public List<int> InorderTraversal(TreeNode root) {
        // We define a helper function Inorder that takes a TreeNode as an argument. This function will perform the inorder traversal of the binary tree.
        // We also initialize an empty list res to store the values of the nodes in the order they are visited during the traversal.
        List<int> res = new List<int>();
        void Inorder(TreeNode node) {
            // If the current node is null, we return immediately, as there are no nodes to process.
            if (node == null) return;
            // If the current node is not null, we first recursively call Inorder on the left child of the current node. This will visit all the nodes in the left subtree before processing the current node.
            Inorder(node.left);
            // After visiting the left subtree, we add the value of the current node to the res list.
            res.Add(node.val);
            // Finally, we recursively call Inorder on the right child of the current node, which will visit all the nodes in the right subtree.
            Inorder(node.right);
        }
        Inorder(root);
        return res;
    }
}