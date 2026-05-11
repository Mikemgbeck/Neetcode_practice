public class Solution {
    public int RemoveElement(int[] nums, int val) 
    {
        // We use a two-pointer approach to solve this problem. The first pointer (indexStore) 
        // keeps track of the position where we will store the next non-val element, while the second pointer (i) iterates through the array.
        int indexStore = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            // If the current element is not equal to val, we store it at the indexStore position and increment indexStore.
            if (nums[i] != val)
            {
                // We copy the current element to the indexStore position and then increment indexStore to point to the next position for storing.
                nums[indexStore] = nums[i];
                indexStore++;
            }
        }
        return indexStore;
    }
}