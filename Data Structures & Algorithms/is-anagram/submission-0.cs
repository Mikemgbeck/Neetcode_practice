public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        //check if same string if true return false
        if (s == t || s.length != t.length)
        {
            return false;
        }
        //create dictionary
        Dictionary<char, int> uniqueChars = new Dictionary<char, int>;
        //for each loop through chars of second string and try to add to the hashset
        foreach (char c in t)
        {
            if (!uniqueChars.Add(c)) {
                return false; // Duplicate not found
            }
            return true; // each char a duplicate

        }
        return false;
    }
}
