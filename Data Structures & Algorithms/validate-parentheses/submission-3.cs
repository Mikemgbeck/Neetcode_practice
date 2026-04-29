public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>(s);
        foreach( char bracket in s)
        {
            if(bracket == '{' || bracket == '(' || bracket == '[')
            {
                stack.Push(bracket);
            } if (bracket == '}')
            {
                if (stack.Count == 0 || stack.Pop() != '{')
                {
                    return false;
                }
            } if (stack.Count == 0 || bracket == ')')
            {
                if (stack.Pop() != '(')
                {
                    return false;
                }
            } if (stack.Count == 0 || bracket == ']')
            {
                if (stack.Pop() != '[')
                {
                    return false;
                }
            }
        }
        return true;
    }
}
