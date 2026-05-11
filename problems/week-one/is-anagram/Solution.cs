public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        //check if different length return false
        if (s.Length != t.Length)
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
                //if the value is less than 0 return false this means the counts dont match and we already knoe=wn the lengths are the same so we know they are not anagrams
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