public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>(s);
        foreach( char bracket in s)
        {
            if(bracket == '{' || bracket == '(' || bracket == '[')
            {
                stack.Push(bracket);
            }else if (stack.Count == 0 || bracket == '}')
            {
                if (stack.Pop() != '{')
                {
                    return false;
                }
            } else if ( stack.Count == 0 || bracket == ')')
            {
                if (stack.Pop() != '(')
                {
                    return false;
                }
            }else if (stack.Count == 0 || bracket == ']')
            {
                if (stack.Pop() != '[')
                {
                    return false;
                }
            }
        }
        // this should be true for any successes 
        return stack.Count == 0;
    }
}
