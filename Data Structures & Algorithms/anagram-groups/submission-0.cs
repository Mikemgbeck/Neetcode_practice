public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // initilise output list
        List<string> output = new List<string>;
        
        //create a hashmap of the arrays string

        //for each loop for each string in the array

        //use a int count to check lenth we want to only check each length once

        //initilise string list group to hold this word and anagrams of this word (empty for now)


            //second loop for each string in the array
                //check vs lengthcount

                //check if anagram vs string from first loop (even if same word)
                    //check if different length return false

                    //create dictionary of chars and counts for the string 

                    //loop through first string chars and add to dictionary 

                        //if contained add one to value

                        //if not add to the dictionary

                    //loop through second string chars 
                        //if contaied reduce the count
                            //if under 0 not anagram 
                        //if not contained not angram
                    
                //if we get here add the word to the list(should succeed on same word and anagrams)

        //Increae count

        //add group to output

    //return output
        
    }
}
