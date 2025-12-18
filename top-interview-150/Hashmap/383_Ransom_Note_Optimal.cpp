// 383. Ransom Note

// Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.
// Each letter in magazine can only be used once in ransomNote.

//MOST OPTIMAL SOLUTION (no unordered_map)

class Solution {
public:
    bool canConstruct(string ransomNote, string magazine) {

        if(magazine.size() < ransomNote.size()){
            return false;
        }

        int letters[26];

        for(char c : magazine){
            letters[c - 'a']++;
        }

        for(char c : ransomNote){
            if(--letters[c - 'a'] < 0){
                return false;
            }
        }

        return true;
    }
};