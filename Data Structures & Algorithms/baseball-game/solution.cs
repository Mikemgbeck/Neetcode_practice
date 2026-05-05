public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> scoreStack = new Stack<int>();
        int score = 0;
        foreach (string operation in operations)
        {
            if (operation == "+")
            {
                // get the last two score and add them together and push the result onto the stack
                int lastScore = scoreStack.Pop();
                int secondLastScore = scoreStack.Peek();
                scoreStack.Push(lastScore);
                scoreStack.Push(lastScore + secondLastScore);
            } else if (operation == "D")
            {
                scoreStack.Push(scoreStack.Peek() * 2);
            } else if (operation == "C")
            {
                scoreStack.Pop();
            } else
            {
                //int.parse instead of casting
                scoreStack.Push(int.Parse(operation));
            }
        }
        //stacks dont support indexing so use for each 
        foreach (int points in scoreStack)
        {   
            score += points;
        }
        return score;
    }
}