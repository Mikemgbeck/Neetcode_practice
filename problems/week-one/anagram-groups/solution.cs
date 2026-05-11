public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        // Dictionary to group anagrams: key is a string of char counts, value is list of anagrams
        Dictionary<string, List<string>> groupsBySignature = new Dictionary<string, List<string>>();

        // Iterate through each string in the input array
        foreach (string currentString in strs)
        {
            // Array to count occurrences of each lowercase letter (a-z, 26 letters)
            int[] charCounts = new int[26];

            // Count each character in the current string
            foreach (char currentChar in currentString)
            {
                charCounts[currentChar - 'a']++;  // 'a' is 0, 'b' is 1, etc.
            }

            // Create a unique key from the counts array (e.g., "1,0,0,...,1" for "eat")
            string countKey = string.Join(",", charCounts);

            // If this key doesn't exist, create a new list for it
            if (!groupsBySignature.ContainsKey(countKey))
            {
                groupsBySignature[countKey] = new List<string>();
            }

            // Add the current string to the group for this key
            groupsBySignature[countKey].Add(currentString);
        }

        // Return all the grouped lists (the values of the dictionary)
        return new List<List<string>>(groupsBySignature.Values);
    }
}