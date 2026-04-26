public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        HashSet<int> hashSet = new HashSet<int>(nums);
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (hashSet.Contains(complement)) {
                return new int[] { i, Array.IndexOf(nums, complement) };
            }
        }
        return new int[0]; // Return an empty array if no solution is found
    }
}
