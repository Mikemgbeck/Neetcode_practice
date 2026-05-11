public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();

        foreach (char c in s) {
            switch (c) {
                case ')':
                    if (stack.Count == 0 || stack.Pop() != '(') return false;
                    break;
                case ']':
                    if (stack.Count == 0 || stack.Pop() != '[') return false;
                    break;
                case '}':
                    if (stack.Count == 0 || stack.Pop() != '{') return false;
                    break;
                default:
                    // opening bracket
                    stack.Push(c);
                    break;
            }
        }

        return stack.Count == 0;
    }
}