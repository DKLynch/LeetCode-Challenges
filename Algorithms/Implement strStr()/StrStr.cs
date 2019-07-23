//Problem URL: https://leetcode.com/problems/implement-strstr/

public class Solution {
    public int StrStr(string haystack, string needle) {

        //If the strings match, return 0
        if(haystack == needle || needle == "")
            return 0;

        //If the string to match is longer than the checked string,
        //or does not actually contain the string to match, return -1
        if(needle.Length > haystack.Length)
            return -1;

        for(int i = 0; i <= haystack.Length - needle.Length; i++){  

            //if the current character matches the first character of the string to match
            //and the character x.Length positions from now also matches, loop through the
            //intermediate characters and break if any characters don't match.
            if(haystack[i] == needle[0] && haystack[i + needle.Length - 1] == needle[needle.Length - 1]){
                for(int j = 0; j < needle.Length; j++){

                    if(haystack[i+j] != needle[j])
                        break;

                    if(j == needle.Length - 1)
                        return i;
                }
            }
        }

        return -1;
    }
}
