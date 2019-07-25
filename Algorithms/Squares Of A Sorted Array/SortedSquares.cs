//Problem URL: https://leetcode.com/problems/squares-of-a-sorted-array/

public class Solution {
    public int[] SortedSquares(int[] A) {
        List<int> squares = new List<int>();
        
        foreach(int n in A){
            squares.Add(n * n);
        }
        
        squares.Sort();
        return squares.ToArray();
    }
}
