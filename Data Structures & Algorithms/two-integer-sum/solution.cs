public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //Initialize an empty hash map to store numbers and their indices.
        Dictionary<int, int> map = new Dictionary<int, int>();
        //Iterate through the array. Start at index i = 0
        for (int i = 0; i < nums.Length; i++) {
            // find the compliment as we know the sum we want
            int complement = target - nums[i];
            // check if the map contains the compliment
            if (map.ContainsKey(complement)) {
                //return the int of the compiment and the current index
                return new int[] { map[complement], i };
            }
            //store the visited numbers and thier index
            map[nums[i]] = i;
        }
        return new int[0]; // Return an empty array if no solution is found
    }
}
