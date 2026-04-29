public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        foreach( char bracket in s)
        {
            if(bracket == '{' || bracket == '(' || bracket == '[')
            {
                stack.Push(bracket);
            } if (bracket == '}')
            {
                if (stack.Peek() == '{')
                {
                    stack.Push(bracket);
                } else
                {
                    return false;
                }
            } if (bracket == ')')
            {
                if (stack.Peek() == '(')
                {
                    stack.Push(bracket);
                } else
                {
                    return false;
                }
            } if (bracket == ']')
            {
                if (stack.Peek() == '{')
                {
                    stack.Push(bracket);
                } else
                {
                    return false;
                }
            }
        }
        return true;
    }
}
