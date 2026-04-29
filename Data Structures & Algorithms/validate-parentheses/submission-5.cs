public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>(s);
        foreach( char bracket in s)
        {
            if (bracket == ')') {
                if (stack.Count == 0 || stack.Pop() != '(') return false;
            } 
            else if (bracket == ']') {
                if (stack.Count == 0 || stack.Pop() != '[') return false;
            } 
            else if (bracket == '}') {
                if (stack.Count == 0 || stack.Pop() != '{') return false;
            } 
            else {
                // opening bracket
                stack.Push(bracket);
            }
        }
        return true;
    }
}
