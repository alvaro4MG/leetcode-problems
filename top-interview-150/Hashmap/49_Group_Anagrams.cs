// 49. Group Anagrams

// Given an array of strings strs, group the anagrams together. You can return the answer in any order.

// NOT OPTIMAL SOLUTION for runtime, but for memory

public class Solution {

    private bool IsAnagram(string s, string t) {

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

    public IList<IList<string>> GroupAnagrams(string[] strs) {
        bool[] taken = new bool[strs.Length];
        IList<IList<string>> result = new List<IList<string>>();

        for(int i = 0; i < strs.Length; i++){
            List<string> anagramList = new List<string>();

            if(!taken[i]){
                anagramList.Add(strs[i]);

                for(int j = (i+1); j < strs.Length; j++){
                    if(IsAnagram(strs[i],strs[j])){
                        anagramList.Add(strs[j]);
                        taken[j] = true;
                    }
                }
                result.Add(anagramList);
            }

        }

        return result;

    }
}