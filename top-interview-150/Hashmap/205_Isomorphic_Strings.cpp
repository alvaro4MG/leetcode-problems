// 205. Isomorphic Strings

// Given two strings s and t, determine if they are isomorphic.
// Two strings s and t are isomorphic if the characters in s can be replaced to get t.
// All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character, but a character may map to itself.

// NOT OPTIMAL SOLUTION

class Solution {
public:
    bool isIsomorphic(string s, string t) {
        unordered_map<char, char> letters;
        unordered_map<char, char> letters2;
        int i = 0;

        for(char c : s){
            if(!letters.contains(c)){
                letters[c] = t[i];
            }else{
                if(letters[c] != t[i]){
                    return false;
                }
            }

            if(!letters2.contains(t[i])){
                letters2[t[i]] = c;
            }else{
                if(letters2[t[i]] != c){
                    return false;
                }
            }

            i++;
        }

        return true;
    }
};