public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        // We use three pointers to merge the two sorted arrays in place. The first pointer (last) starts from the end of the merged array,
        // while the other two pointers (i and j) start from the end of nums1 and nums2, respectively.
        int last = m + n - 1;
        int i = m - 1, j = n - 1;

        // We compare the elements pointed to by i and j, and we place the larger one at the position pointed to by last.
        //  We then move the corresponding pointer (i or j) and decrement last.
        while (j >= 0) {
            // If the current element in nums1 is greater than the current element in nums2, we place it at the last position and move the i pointer.
            if (i >= 0 && nums1[i] > nums2[j]) {
                // We copy the current element from nums1 to the last position and then decrement both the i pointer and the last pointer.
                nums1[last--] = nums1[i--];
                // If the current element in nums2 is greater than or equal to the current element in nums1, place it at the last position and move the j pointer.
            } else {
                // We copy the current element from nums2 to the last position and then decrement both the j pointer and the last pointer.
                nums1[last--] = nums2[j--];
            }
        }
    }
}