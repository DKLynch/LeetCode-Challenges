//Problem URL: https://leetcode.com/problems/unique-email-addresses/

//Quite possibly the least efficient method of completing this task, however, it does work.
//I may revisit this in the future and try to find a more performant method, in both time and space complexity.
public class Solution {
    public int NumUniqueEmails(string[] emails) {
        List<string> emailees = new List<string>();
        string[] splitEmail = new string[2]{"", ""};
        string localName = "";
        string domainName = "";
        string treatedEmail = "";
        
        foreach(string e in emails){
            splitEmail = e.Split('@');
            localName = splitEmail[0].Replace(".", "").Split('+')[0];
            domainName = splitEmail[1];
            treatedEmail = localName + "@" + domainName;
            
            emailees.Add(treatedEmail);
        }
        
        return emailees.Distinct().Count();
    }
}
