public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        // We sort the points based on their distance from the origin (0, 0). The distance is calculated using the formula: distance = sqrt(x^2 + y^2).
         Array.Sort(points, (a, b) =>
         // We compare the squared distances of the points from the origin to avoid unnecessary square root calculations, which can be computationally expensive.
        (a[0] * a[0] + a[1] * a[1]).CompareTo(b[0] * b[0] + b[1] * b[1]));
        return points[..k];
        
    }
}
