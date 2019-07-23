//Problem URL: https://leetcode.com/problems/n-repeated-element-in-size-2n-array/

public class Solution {
    public int RepeatedNTimes(int[] A) {
        Dictionary<int, int> nums = A.GroupBy(x => x)
            .Select(num => new {num = num.Key, count = num.Count()})
            .ToDictionary(a => a.num, a => a.count);
        
        foreach(var entry in nums){
            if(entry.Value == A.Length/2)
                return entry.Key;
        }
        
        return 0;
    }
}
