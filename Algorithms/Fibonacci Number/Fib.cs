//Problem URL: https://leetcode.com/problems/fibonacci-number/

public class Solution {
    public int Fib(int N) {     
        if(N == 1)
            return 1;
        
        int[] prevFibNos = new int[2]{0, 1};
        int newFibNo = 0;
        
        for(int i = 2; i <= N; i++){
            newFibNo = prevFibNos[0] + prevFibNos[1];
            prevFibNos[0] = prevFibNos[1];
            prevFibNos[1] = newFibNo;
        }

        return newFibNo;
    }
}
