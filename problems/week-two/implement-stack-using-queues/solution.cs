public class MyStack {
    private Queue<object> q;

    public MyStack() {
        // We use a single queue to implement the stack. The idea is to always keep the top element of the stack at the front of the queue.
        q = null;
    }

    public void Push(int x) {
        // When we push an element onto the stack, we create a new queue and enqueue the new element followed by all the elements of the existing queue.
        //  This way, the new element becomes the front of the queue, which represents the top of the stack
        Queue<object> newQueue = new Queue<object>();
        newQueue.Enqueue(x);
        newQueue.Enqueue(q);
        q = newQueue;
    }

    public int Pop() {
        // To pop an element from the stack, we simply dequeue the front element of the queue, which is the top of the stack.
        if (q == null) return -1;
        // We store the front element of the queue (the top of the stack) in a variable, then we update the queue to be the next queue in line (the second element of the current queue).
        int top = (int)q.Dequeue();
        q = (Queue<object>)q.Dequeue();
        return top;
    }

    public int Top() {
        // To get the top element of the stack without removing it, we simply peek at the front element of the queue.
        if (q == null) return -1;
        return (int)q.Peek();
    }

    public bool Empty() {
        // The stack is empty if the queue is null.
        return q == null;
    }
}