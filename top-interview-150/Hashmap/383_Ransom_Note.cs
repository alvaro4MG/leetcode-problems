// 383. Ransom Note

// Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.
// Each letter in magazine can only be used once in ransomNote.

public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int i = 0;
        int j = 0;
        bool[] taken = new bool[magazine.Length];
        bool found = false;

        if(ransomNote.Length > magazine.Length){
            return false;
        }

        for(i = 0; i < ransomNote.Length; i++){
            for(j = 0; !found && (j < magazine.Length); j++){
                if(!taken[j] && ransomNote[i] == magazine[j]){
                    taken[j] = true;
                    found = true;
                }
            }
            if(!found){
                return false;
            }
            found = false;
        }

        return true;
    }
}