public class Solution {
    public int RemoveElement(int[] nums, int val) 
    {
        int indexStore = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[indexStore] = nums[i];
                indexStore++;
            }
        }
        return indexStore;
    }
}