// 392. Is Subsequence

// Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
// A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).

class Solution {
public:
    bool isSubsequence(string s, string t) {
        int i = 0;
        int j = 0;

        if(s.size() == 0){
            return true;
        }

        if(t.size() < s.size()){
            return false;
        }

        for(; i < t.size(); i++){
            if(t[i] == s[j]){
                if(j == s.size()-1){
                    return true;
                }
                j++;
            }
            
        }

        return false;
    }
};