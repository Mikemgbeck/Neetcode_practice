public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        //check if same string if true return false
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
                uniqueChars[c]++;
            }
            else
            {
                uniqueChars.Add(c, 1);
            }
        }
        //loop through string t and check if character is in dictionary if true decrease count by 1
        foreach (char c in t)           
        {
            if (uniqueChars.ContainsKey(c))
            {
                uniqueChars[c]--;
            }
            else                
            {
                return false;
            }
        }
            //loop through dictionary and check if value is not 0 if true return false
        foreach (KeyValuePair<char, int> kvp in uniqueChars)            
        {
            if (kvp.Value != 0)                
            {
                return false; // same letters but different value
            }
            return true;
        }
        return false;
    }
}