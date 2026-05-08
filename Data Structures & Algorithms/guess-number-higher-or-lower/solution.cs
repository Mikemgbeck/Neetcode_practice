/**
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        // We use a binary search algorithm to find the picked number. We initialize two pointers, l and r, 
        // to represent the left and right boundaries of the search space, which initially are 1 and n, respectively.
        int l = 1, r = n;
        // We enter a loop that continues indefinitely until we find the picked number.
        while (true) {
            // We calculate the middle index m of the current search space using the formula l + (r - l) / 2 to avoid potential overflow issues that can arise 
            // with (l + r) / 2.
            int m = l + (r - l) / 2;
            // We call the guess API with the middle index m to get feedback on whether m is higher, lower, or equal to the picked number.
            int res = guess(m);
            // If the result res is greater than 0, it means that m is lower than the picked number, so we move the left pointer l to m + 1 to search in the right half of the current search space.
            if (res > 0) {
                l = m + 1;
            }
            // If the result res is less than 0, it means that m is higher than the picked number, so we move the right pointer r to m - 1 to search in the left half of the current search space.
            else if (res < 0) {
                r = m - 1;
            // If the result res is equal to 0, it means that m is equal to the picked number, so we have found the picked number and we return m.
            }
            else {
                return m;
            }
        }
    }
}