// 125. Valid Palindrome

// A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.
// Given a string s, return true if it is a palindrome, or false otherwise.

public class Solution {

    private int checkAN(string s, int i, int displace, int j){
        while( (i != j) && !char.IsLetterOrDigit(s[i]) ){
            i = i + displace;
        }
        return i;
    }

    public bool IsPalindrome(string s) {
        int i = 0;
        int j = s.Length - 1;

        while(i < j){
            i = checkAN(s, i, 1, j);
            j = checkAN(s, j, -1, i);
            if(char.ToLower(s[i]) != char.ToLower(s[j]) ){
                return false;
            }
            i++;
            j--;
        }

        return true;
    }
}