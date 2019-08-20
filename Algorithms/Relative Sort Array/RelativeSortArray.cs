//Problem URL: https://leetcode.com/problems/relative-sort-array/

public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        List<int> sortedNums = new List<int>();
        List<int> tempList = new List<int>(arr1);
    
        foreach(int i in arr2){
            int occurences = arr1.Count(x => x == i);
            
            for(int j = 0; j < occurences; j++){
                sortedNums.Add(i);
            }
            
            tempList.RemoveAll(x => x.Equals(i));
        }
        
        sortedNums.AddRange(tempList.OrderBy(x => x));
        return sortedNums.ToArray();       
    }
}
