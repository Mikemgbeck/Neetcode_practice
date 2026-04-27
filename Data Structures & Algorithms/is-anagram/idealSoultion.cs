public class Solution {
    public bool IsAnagram(string s, string t)
    {
        //check if these are anagrams O(n) time complexity and O(1) space complexity since we are only using a fixed size array of 26 characters (letters in alphabet)
        int[] charCount = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            charCount[s[i] - 'a']++;
            charCount[t[i] - 'a']--;
        }
        foreach (int count in charCount)
        {
            if (count != 0)
            {
                return false;
            }
        }
        return true;
    }
}