public class Solution
{
    public bool IsAnagram(string firstString, string secondString)
    {
        // Check if these are anagrams O(n) time complexity and O(1) space complexity since we are only using a fixed size array of 26 characters (letters in alphabet)
        if (firstString.Length != secondString.Length)
        {
            return false;
        }
        int[] characterCounts = new int[26];
        for (int index = 0; index < firstString.Length; index++)
        {
            // Increment the count for the character in the first string 
            characterCounts[firstString[index] - 'a']++;
            // Decrement the count for the character in the second string
            characterCounts[secondString[index] - 'a']--;
        }
        foreach (int frequency in characterCounts)
        {
            // If any frequency is not zero, then the strings are not anagrams
            if (frequency != 0)
            {
                return false;
            }
        }
        // If we reach this point, the strings are anagrams
        return true;
    }
}