//Problem URL: https://leetcode.com/problems/defanging-an-ip-address/

public class Solution {
    public string DefangIPaddr(string address) {
        var newAddress = address.Replace(".", "[.]");
        return newAddress;
    }
}
