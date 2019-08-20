//Problem URL: https://leetcode.com/problems/height-checker/

public class Solution {
    public int HeightChecker(int[] heights) {
        int[] clone = (int[])heights.Clone();
        Array.Sort(clone);
       
        int counter = 0;
        for(int i = 0; i < clone.Length; i++){
            if(heights[i] != clone[i])
                counter++;
        }
        
        return counter;
    }
}
