// 242. Valid Anagram

// Given two strings s and t, return true if t is an anagram of s, and false otherwise.

public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length){
            return false;
        }

        Dictionary<char,int> counter = new Dictionary<char,int>();

        for(int i = 0; i < s.Length; i++){
            if(counter.ContainsKey(s[i])){
                counter[s[i]]++;
            }else{
                counter.Add(s[i], 1);
            }
        }

        for(int i = 0; i < t.Length; i++){
            if(counter.ContainsKey(t[i])){
                counter[t[i]]--;
                if(counter[t[i]] < 0){
                    return false;
                }
            }else{
                return false;
            }
        }

        return true;


    }
}