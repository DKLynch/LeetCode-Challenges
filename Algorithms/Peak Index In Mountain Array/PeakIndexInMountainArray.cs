//Problem URL: https://leetcode.com/problems/peak-index-in-a-mountain-array

//Originally I went with the solution below, but I figured in the interest of answering the problem
//without utilizing in-built functions, I should rewrite the solution to manually loop through.

public class Solution {
    public int PeakIndexInMountainArray(int[] A) {
        int maxPeak = Int32.MinValue;
        int peakIndex = 0;
        
        for(int i = 0; i < A.Length; i++){
            if(A[i] > maxPeak){
                maxPeak = A[i];
                peakIndex = i;
            }
        }
        
        return peakIndex;
    }
}

/*
public class Solution {
    public int PeakIndexInMountainArray(int[] A) {
        return Array.IndexOf(A, A.Max());
    }
}
*/
