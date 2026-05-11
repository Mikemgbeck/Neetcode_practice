public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        // We use a binary search algorithm to find the minimum eating speed k that allows Koko to finish all the bananas in h hours.
        // We initialize the left pointer l to 1, which is the minimum possible eating speed
        // We initialize the right pointer r to the maximum number of bananas in any pile, which is the maximum possible eating speed.
        int l = 1;
        int r = piles.Max();
        int res = r;
        // We enter a loop that continues as long as the left pointer is less than or equal to the right pointer.
        while (l <= r) {
            // We calculate the middle eating speed k of the current search space. We use the formula (l + r) / 2 to find the midpoint.
            int k = (l + r) / 2;
            // We calculate the total time it takes for Koko to eat all the bananas at the current eating speed k.
            long totalTime = 0;
            // We iterate through each pile of bananas in the piles array. For each pile p, we calculate the time it takes for Koko to eat that pile at speed k.
            foreach (int p in piles) {
                totalTime += (int)Math.Ceiling((double)p / k);
            }
            // If the total time is less than or equal to h, it means that Koko can finish all the bananas at speed k, 
            // so we update the result res to k and move the right pointer r to k - 1 to search for a potentially smaller eating speed.
            if (totalTime <= h) {
                res = k;
                r = k - 1;
            // If the total time is greater than h, it means that Koko cannot finish all the bananas at speed k,
            // so we move the left pointer l to k + 1 to search for a larger eating speed.
            } else {
                l = k + 1;
            }
        }
        // After the loop, res will contain the minimum eating speed that allows Koko to finish all the bananas in h hours, and we return res.
        return res;
    }
}