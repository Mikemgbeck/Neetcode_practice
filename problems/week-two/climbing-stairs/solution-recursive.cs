public class Solution {
    public int ClimbStairs(int n) {    
        // The number of ways to climb n stairs is the (n+1)th Fibonacci number. 
              return Dfs(n, 0);
    }

    public int Dfs(int n, int i) {
        // Base case: if we have climbed n stairs, there is one way to do it (by taking the last step). If we have climbed more than n stairs, 
        // there are no ways to do it.
        if (i >= n) return i == n ? 1 : 0;
        // Recursive case: the number of ways to climb n stairs from step i is the sum of the number of ways to climb n stairs from step i + 1 
        // and the number of ways to climb n stairs from step i + 2.
        return Dfs(n, i + 1) + Dfs(n, i + 2);
        //this is a brute-force recursive solution that explores all possible combinations of steps. 
        // It has an exponential time complexity of O(2^n) because each step can lead to two further steps (i + 1 and i + 2).
    }
}
