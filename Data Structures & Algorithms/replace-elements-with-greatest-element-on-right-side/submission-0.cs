public class Solution {
    public int[] ReplaceElements(int[] arr) {

        //key here is looping right to left not left to right. We can keep track of the max value to the right of the current index as we loop through the array. We can then replace the current index with the max value to the right and update the max value if the current index is greater than the max value.
        int rightMax = -1;
        //loop right to left
        for (int i = arr.Length - 1; i >= 0; i--) {
            int current = arr[i];
            //replace the current index with the max value to the right
            arr[i] = rightMax;
            //update the max value to the right if the current index is greater than the max value
            if (current > rightMax)
            {
                rightMax = current;
            }
        }
        return arr;
    }
}