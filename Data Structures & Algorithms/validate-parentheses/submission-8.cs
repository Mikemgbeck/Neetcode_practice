public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        foreach( char bracket in s)
        {
            if ( bracket == ')')
            {
                if (stack.Count == 0 || stack.Pop() != '(') return false;
                
            } else if ( bracket == ']')
            {
                if (stack.Count == 0 || stack.Pop() != '[') return false;
                
            }else if ( bracket == '}')
            {
                if (stack.Count == 0 || stack.Pop() != '{') return false;
                
            } else
            {
                stack.Push(bracket);
            }
        }
        // this should be true for any successes 
        return stack.Count == 0;
    }
}
