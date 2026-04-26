public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //needed to find the duplicate adding
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            // find the 
            int complement = target - nums[i];
            if (map.ContainsKey(complement) && map[complement] != i) {
                return new int[] { map[complement], i };
            }
        }
        return new int[0]; // Return an empty array if no solution is found
    }
}
