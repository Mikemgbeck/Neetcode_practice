public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int max = 0;
        int consecutive = 0;

        //create a for loop over the length of the array
        for (i = 0, i < nums.Length, i++)
        {
            if (nums[i] == 1)
            {
                consecutive++;

                //if consecutive > max
                if
                {
                    max = consecutive;
                }
            }
            else
            {
                consecutive = 0;
            }
        }
        return consecutive;
    }
}