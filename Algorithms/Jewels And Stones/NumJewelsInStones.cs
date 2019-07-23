//Problem URL: https://leetcode.com/problems/jewels-and-stones/

public class Solution {
    public int NumJewelsInStones(string J, string S) {
        int matches = 0;
        
        foreach(char c in J){
            foreach(char d in S){
                if(c == d)
                    matches++;
            }
        }
        
        return matches;
    }
}
