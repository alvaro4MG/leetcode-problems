// 392. Is Subsequence

// Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
// A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).

public class Solution {
    public bool IsSubsequence(string s, string t) {
        int j = s.Length - 1;
        
        for(int i = (t.Length - 1); (j >= 0) && (i >= 0); i--){
            if(t[i] == s[j]){
                j--;
            }
        }
        if(j >= 0){
            return false;
        }else{
            return true;
        }
    }
}