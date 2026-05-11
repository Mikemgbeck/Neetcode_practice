public class Solution {
    public int Search(int[] nums, int target) {
        // We use a binary search algorithm to find the target in the sorted array nums. 
        // We initialize two pointers, l and r, to represent the left and right boundaries of the search space.
        
        int l = 0, r = nums.Length - 1;

        // We enter a loop that continues as long as the left pointer is less than or equal to the right pointer.   
        while (l <= r) {
            // We calculate the middle index m of the current search space. We use the formula l + ((r - l) / 2) 
            // to avoid potential overflow issues that can arise with (l + r) / 2.
            int m = l + ((r - l) / 2);
            // We compare the middle element nums[m] with the target. 
            // If nums[m] is greater than the target, it means that the target must be in the left half of the current search space, 
            // so we move the right pointer r to m - 1.
            if (nums[m] > target) {
                r = m - 1;
            // If nums[m] is less than the target, it means that the target must be in the right half of the current search space,
            // so we move the left pointer l to m + 1.
            } else if (nums[m] < target) {
                l = m + 1;
            // If nums[m] is equal to the target, we have found the target and we return the index m.
            } else {
                return m;
            }
        }
        // If we exit the loop without finding the target, it means that the target is not present in the array, and we return -1.
        return -1;
    }
}
