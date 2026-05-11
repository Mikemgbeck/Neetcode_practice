public class MinStack {
    private Stack<int> stack;

    public MinStack() {
        stack = new Stack<int>();
    }

    public void Push(int val) {
        stack.Push(val);
    }

    public void Pop() {
        stack.Pop();
    }

    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() 
    {
        //copy the original stack to a new stack to preserve the original after pops
        Stack<int> tempStack = new Stack<int>(stack);
        int min = tempStack.Peek();
        while (tempStack.Count > 0) 
        {
            int val = tempStack.Pop();
            if (val < min) 
            {
                min = val;
            }
        }
        return min;
    }
}
