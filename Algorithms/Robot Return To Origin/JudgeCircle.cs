//Problem URL: https://leetcode.com/problems/robot-return-to-origin

public class Solution {
    public bool JudgeCircle(string moves) {
        int x = 0;
        int y = 0;
        
        foreach(char c in moves){
            switch(c){
                case 'U':
                    y++;
                    break;
                case 'D':
                    y--;
                    break;
                case 'L':
                    x--;
                    break;
                case 'R':
                    x++;
                    break;
            }
        }
        
        return (x == 0 && y == 0);
    }
}
