public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> scoreStack = new Stack<int>;
        int score = 0;
        ForEach (operation in operations)
        {
            if (operation == "+")
            {
                scoreStack.Push(scoreStack.Skip(1).First() + scoreStack.Skip(2).First());
            } else if (operation == "D")
            {
                scoreStack.Push(scoreStack.Peek() * 2);
            } else if (operation == "C")
            {
                scoreStack.Pop();
            } else
            {
                scoreStack.Push((int)operation);
            }
        }
        for (int i = 0; i < scoreStack.Length; i++)
        {   
            score += scoreStack[i];
        }
        return score;
    }
}