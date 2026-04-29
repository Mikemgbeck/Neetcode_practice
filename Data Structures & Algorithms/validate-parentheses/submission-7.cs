public class Solution {
    public bool IsValid(string s) {
        //this initilization with s caused me so many issues 
        var stack = new Stack<char>(s);
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
public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();

        foreach (char c in s) {
            if (c == ')') {
                if (stack.Count == 0 || stack.Pop() != '(') return false;
            } 
            else if (c == ']') {
                if (stack.Count == 0 || stack.Pop() != '[') return false;
            } 
            else if (c == '}') {
                if (stack.Count == 0 || stack.Pop() != '{') return false;
            } 
            else {
                // opening bracket
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }
}