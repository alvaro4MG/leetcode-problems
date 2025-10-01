// 290. Word Pattern

// Given a pattern and a string s, find if s follows the same pattern.
// Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s. Specifically:
    // Each letter in pattern maps to exactly one unique word in s.
    // Each unique word in s maps to exactly one letter in pattern.
    // No two letters map to the same word, and no two words map to the same letter.

public class Solution {
    public bool WordPattern(string pattern, string s) {
        Dictionary<char,string> map = new Dictionary<char,string>();
        string[] words = s.Split(' ');

        if(pattern.Length != words.Length){
            return false;
        }

        for(int i = 0; i < pattern.Length; i++){
            if(map.ContainsKey(pattern[i])){
                if(map[pattern[i]] != words[i]){
                    return false;
                }
            }else{
                if(map.ContainsValue(words[i])){
                    return false;
                }else{
                    map.Add(pattern[i], words[i]);
                }
            }
        }

        return true;

    }
}