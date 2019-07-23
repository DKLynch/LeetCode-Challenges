//Problem URL: https://leetcode.com/problems/unique-morse-code-words/

public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
		List<string> morseReps = new List<string>();
        string[] morseLetters = new string[26]{".-","-...","-.-.","-..",".","..-.","--.","....","..",
			".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-",
			"-.--","--.."};
  
        foreach(string word in words){
            string morse = "";
            foreach(char c in word){
                int charIndex = (int)((c % 32) - 1);
                morse += morseLetters[charIndex];
            }
            
            morseReps.Add(morse);
        }
        
        return morseReps.Distinct().Count();
    }
}
