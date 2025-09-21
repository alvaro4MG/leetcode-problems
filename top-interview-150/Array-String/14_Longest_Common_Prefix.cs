// 14. Longest Common Prefix (Array/String)

// Write a function to find the longest common prefix string amongst an array of strings.
// If there is no common prefix, return an empty string "".

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int prefix = 0;
        int i = 0;
        int j = 0;
        int minSize = 201;

        if(strs.Length == 0){
            return "";
        }else if(strs.Length == 1){
            return strs[0];
        }

        for(i = 0; i < strs.Length; i++){
            if(strs[i].Length < minSize){
                minSize = strs[i].Length;
            }
        }
        if(minSize == 0){
            return "";
        }

        for(i = 0; i < minSize; i++){
            for(j = 1; j < strs.Length; j++){
                if(strs[0][i] != strs[j][i]){
                    return strs[0].Substring(0,prefix);
                }
            }
            prefix++;
        }

        return strs[0].Substring(0,prefix);
    }
}