//Problem URL: https://leetcode.com/problems/find-common-characters

public class Solution {
    public IList<string> CommonChars(string[] A) {
        List<string> commonCharacters = new List<string>();
        int[][] occurencesArr = new int[A.Length][];
        
        // Per string.
        for(int i = 0; i < A.Length; i++){
            int[] currentOccurences = new int[26];
            
            // Check how many times each character occurs.
            for(int j = 0; j < A[i].Length; j++){
                
                // Convert the char to it's alphabetical index.
                int charIndex = (int)(A[i][j] % 32) - 1;
                currentOccurences[charIndex]++;
            }
            
            occurencesArr[i] = currentOccurences;
        }
        
        
        for(int i = 0; i < 26; i++){
            int minOccurences = Int32.MaxValue;
            
            for(int j = 0; j < A.Length; j++){
                
                // Invalidate if the character hasn't occured in any of the strings.
                if(occurencesArr[j][i] == 0){
                    minOccurences = -1;
                    break;
                }
                else{
                    minOccurences = Math.Min(minOccurences, occurencesArr[j][i]);
                }                
            }
            
            // Add the respective character to the final List x times.
            // x being the minimum times a character occurs.
            for(int k = minOccurences; k > 0; k--){
                char character = (char)(97 + i);
                commonCharacters.Add(character.ToString());
            }
        }
        
        return commonCharacters;
    }
}
