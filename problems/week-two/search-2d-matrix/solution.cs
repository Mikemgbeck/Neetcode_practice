public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        // We use a binary search algorithm to find the target in the 2D matrix.
        // We treat the 2D matrix as a 1D sorted array by calculating the corresponding row and column indices for the middle element during the binary search.
        int ROWS = matrix.Length, COLS = matrix[0].Length;
        // We initialize two pointers, l and r, to represent the left and right boundaries of the search space in the 1D representation of the matrix.

        int l = 0, r = ROWS * COLS - 1;
        // We enter a loop that continues as long as the left pointer is less than or equal to the right pointer.
        while (l <= r) {
            int m = l + (r - l) / 2;
            int row = m / COLS, col = m % COLS;
            // We calculate the middle index m of the current search space in the 1D representation. 
            // We then convert this index to the corresponding row and column indices in the 2D matrix using integer division and modulus operations.
            // We compare the middle element matrix[row][col] with the target.
            if (target > matrix[row][col]) {
                l = m + 1;
            // If matrix[row][col] is less than the target, it means that the target must be in the right half of the current search space, 
            // so we move the left pointer l to m + 1.
            } else if (target < matrix[row][col]) {
                r = m - 1;
            // If matrix[row][col] is equal to the target, we have found the target and we return true.
            } else {
                return true;
            }
        }
        // If we exit the loop without finding the target, it means that the target is not present in the matrix, and we return false.
        return false;
    }
}