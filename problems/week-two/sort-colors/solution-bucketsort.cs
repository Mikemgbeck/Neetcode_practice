public class Solution {
    public void SortColors(int[] nums) {
        // We use a counting sort approach to sort the colors in place. We create an array count of size 3 to count the occurrences of each color (0, 1, and 2).
        int[] count = new int[3];
        // We iterate through the input array nums and increment the count for each color based on the value of the current element.
        foreach (int num in nums) {
            count[num]++;
        }
        // After counting the occurrences of each color, we overwrite the input array nums with the sorted colors based on the counts. 
        // We use an index variable to keep track of the position in the nums array where we will write the next color.
        int index = 0;
        for (int i = 0; i < 3; i++) {
            // We write the color i into the nums array count[i] times, and we increment the index accordingly.
            while (count[i]-- > 0) {
                nums[index++] = i;
            }
        }
    }
}