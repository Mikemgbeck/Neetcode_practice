public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //needed to find the duplicate adding
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            // find the compliment as we know the sum we want
            int complement = target - nums[i];

            if (map.ContainsKey(complement) && map[complement] != i) {
                return new int[] { map[complement], i };
            }
            //store the visited numbers and thier index
            map[nums[i]] = i;
        }
        return new int[0]; // Return an empty array if no solution is found

}
