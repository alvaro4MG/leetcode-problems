// 383. Ransom Note

// Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.
// Each letter in magazine can only be used once in ransomNote.

class Solution {
public:
    bool canConstruct(string ransomNote, string magazine) {
        unordered_map<char, int> letters;

        if(magazine.size() < ransomNote.size()){
            return false;
        }

        for(int i = 0; i < magazine.size(); i++){
            if(letters.contains(magazine[i])){
                letters[magazine[i]]++;
            }else{
                //letters[magazine[i]] = 1;
                letters.insert({magazine[i], 1});
            }
        }

        for(int i = 0; i < ransomNote.size(); i++){
            if(!letters.contains(ransomNote[i]) || letters[ransomNote[i]] == 0){
                return false;
            }

            letters[ransomNote[i]]--;
        }

        return true;
    }
};