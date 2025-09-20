// 383. Ransom Note (Hashmap)

// Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.
// Each letter in magazine can only be used once in ransomNote.

//USING HASHMAP

public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int i = 0;

        if(ransomNote.Length > magazine.Length){
            return false;
        }

        Dictionary<char,int> map = new Dictionary<char,int>();

        for(i = 0; i < magazine.Length; i++){
            if(map.ContainsKey(magazine[i])){
                map[magazine[i]]++;
            }else{
                map.Add(magazine[i], 1);
            }
        }

        for(i = 0; i < ransomNote.Length; i++){
            if(map.ContainsKey(ransomNote[i])){
                map[ransomNote[i]]--;
                if(map[ransomNote[i]] < 0){
                    return false;
                }
            }else{
                return false;
            }
        }

        return true;

    }
}