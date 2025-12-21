// 205. Isomorphic Strings

// Given two strings s and t, determine if they are isomorphic.
// Two strings s and t are isomorphic if the characters in s can be replaced to get t.
// All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character, but a character may map to itself.

// MOST OPTIMAL SOLUTION

class Solution {
public:
    bool isIsomorphic(string s, string t) {
        char st[256] = {};
        char ts[256] = {};

        for (int i = 0; i < s.size(); ++i) {
            char a = s[i];
            char b = t[i];

            if (st[a] == 0 && ts[b] == 0) {
                st[a] = b;
                ts[b] = a;
            } else {
                if (st[a] != b || ts[b] != a){
                    return false;
                }
            }
        }
        return true;
    }
};