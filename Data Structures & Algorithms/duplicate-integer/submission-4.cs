public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> uniqueNumbers = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++) {
            // add the numbers to the hash set should return true as soon as the first duplicate is found
            if (!uniqueNumbers.Add(nums[i])) {
                return true; // Duplicate found
            }
        }
        return false; //no duplicates found
    }
}