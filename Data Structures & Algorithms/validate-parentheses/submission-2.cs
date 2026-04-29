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
                if (stack.Pop() != '{')
                {
                    return false;
                }
            } if (bracket == ')')
            {
                if (stack.Pop() != '(')
                {
                    return false;
                }
            } if (bracket == ']')
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
