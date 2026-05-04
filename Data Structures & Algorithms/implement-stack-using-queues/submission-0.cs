public class MyStack {
    private Queue<object> q;

    public MyStack() {
        q = null;
    }

    public void Push(int x) {
        Queue<object> newQueue = new Queue<object>();
        newQueue.Enqueue(x);
        newQueue.Enqueue(q);
        q = newQueue;
    }

    public int Pop() {
        if (q == null) return -1;

        int top = (int)q.Dequeue();
        q = (Queue<object>)q.Dequeue();
        return top;
    }

    public int Top() {
        if (q == null) return -1;
        return (int)q.Peek();
    }

    public bool Empty() {
        return q == null;
    }
}