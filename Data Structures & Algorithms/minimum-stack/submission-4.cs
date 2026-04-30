public class MinStack {
    private Stack<int> stack;
    private long min;


    public MinStack()
    {
        stack = new Stack<int>();
    }

    public void Push(int val)
    {
        //if the stack is empty, set the minimum to the value being pushed and push the value onto the stack.
        //if the value being pushed is greater than or equal to the current minimum, simply push the value onto the stack.

        if (stack.Count == 0) 
        {
            min = val;
            stack.Push(val);
        } 
        //if the value being pushed is less than the current minimum, push a special value onto the stack that encodes the new minimum
        //and the previous minimum, and update the minimum to the new value.
        else if (val < min) 
        {
            //store the previous minimum value as a negative number to indicate it's a previous minimum
            stack.Push((int)(2L * val - min));
            min = val;
        } 
        else 
        {
            stack.Push(val);
        }
        
    }

    public void Pop()
    {
        if (stack.Count == 0) 
        {
            return;
        }
        int top = stack.Pop();
        //if the popped value is less than the current minimum, it means it's a special value that encodes the previous minimum
        //so we need to update the minimum to the previous minimum by using the formula: previous_min = 2 * current_min - encoded_value
        if (top < min) 
        {
            min = 2 * min - top;
        }
    }

    public int Top() 
    {
        if (stack.Count == 0) 
        {
            return -1;
        }
        int top = stack.Peek();
        if (top < min) 
        {
            return (int)min;
        }
        return top;
    }
    
    public int GetMin() 
    {
        return (int)min;
    }
}