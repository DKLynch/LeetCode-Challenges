//Problem URL: https://leetcode.com/problems/self-dividing-numbers/

public class Solution {
    public List<int> SelfDividingNumbers(int left, int right) {
        List<int> divNums = new List<int>();
        
        for(int i = left; i <= right; i++){
            bool res = true;
            var numChars = i.ToString().ToCharArray();          
            foreach(char c in numChars){
                if(i % Char.GetNumericValue(c) != 0)
                    res = false;
            }
            
            if(res)
                divNums.Add(i);
        }
        
        return divNums;
    }
}
