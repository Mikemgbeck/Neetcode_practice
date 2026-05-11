public class Solution {
    public int ClimbStairs(int n) {    
        // The number of ways to climb n stairs is the (n+1)th Fibonacci number. 
     double sqrt5 = Math.Sqrt(5);
     // phi and psi are the two roots of the characteristic equation of the Fibonacci sequence.
        double phi = (1 + sqrt5) / 2;
        double psi = (1 - sqrt5) / 2;
        // We use the closed-form expression for the nth Fibonacci number, known as Binet's formula.
        n++;
        // The formula is: F(n) = (phi^n - psi^n) / sqrt(5)
        return (int) Math.Round((Math.Pow(phi, n) -
                     Math.Pow(psi, n)) / sqrt5);
        // This solution has a time complexity of O(1) and a space complexity of O(1) because it uses a 
        // constant amount of space and performs a fixed number of operations regardless of the input size.
    }
}
