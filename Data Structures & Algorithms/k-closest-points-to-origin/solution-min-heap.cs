public class Solution {
    public int[][] KClosest(int[][] points, int K) {
        // We use a min-heap (priority queue) to find the K closest points to the origin. 
        // We calculate the distance of each point from the origin and add it to the min-heap.
        PriorityQueue<int[], int> minHeap = new PriorityQueue<int[], int>();
        // We iterate through each point in the input array, calculate its distance from the origin, and enqueue it into the min-heap with 
        // the distance as the priority.
        foreach (int[] point in points) {
            // The distance is calculated using the formula: distance = sqrt(x^2 + y^2). 
            // However, we can compare squared distances  to avoid the computational cost of the square root.
            int dist = point[0] * point[0] + point[1] * point[1];
            minHeap.Enqueue(new int[] { dist, point[0], point[1] }, dist);
        }
        // We then dequeue the top K elements from the min-heap, which are the K closest points to the origin, and store them in the result array.
        int[][] result = new int[K][];
        // We iterate K times, each time dequeuing the closest point from the min-heap and adding it to the result array. 
        // The point is stored in the min-heap as an array where the first element is the distance, followed by the x and y coordinates.
        for (int i = 0; i < K; ++i) {
            // We dequeue the closest point from the min-heap, which gives us an array where the first element is the distance, 
            // and the second and third elements are the x and y coordinates of the point, respectively. We then add the coordinates to the result array.
            int[] point = minHeap.Dequeue();
            result[i] = new int[] { point[1], point[2] };
        }
        return result;
    }
}
