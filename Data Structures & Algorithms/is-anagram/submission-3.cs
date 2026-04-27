public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        //check if same string if true return false or if different length return false
        if (s == t || s.Length != t.Length)
        {
            return false;
        }
        //create dictionary
        Dictionary<char, int> uniqueChars = new Dictionary<char, int>();
        //loop through string s and add to dictionary
        foreach (char c in s)        
        {
            if (uniqueChars.ContainsKey(c))
            {
                //add one to the value       
                uniqueChars[c]++;
            }
            else
            {
                //add the key value pair
                uniqueChars.Add(c, 1);
            }
        }
        //loop through string t and check if character is in dictionary if true decrease count by 1
        foreach (char c in t)           
            {
                if (uniqueChars.ContainsKey(c))
                {
                    //reduce the value
                    uniqueChars[c]--;
                    if (uniqueChars[c] < 0)
                    {
                        return false;
                    }
                }
                else                
                {
                    return false;
                }
            }
        return true;
    }
}