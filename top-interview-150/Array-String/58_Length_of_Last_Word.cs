// 58. Length of Last Word (Array / String)

// Given a string s consisting of words and spaces, return the length of the last word in the string.
// A word is a maximal substring consisting of non-space characters only.

public class Solution {
    public int LengthOfLastWord(string s) {
        int i = s.Length - 1;
        int counter = 0;

        while( (i >= 0) && (s[i] != ' ') || (counter == 0) ){
            if(s[i] != ' '){
                counter++;
            }
            i--;
        }

        return counter;
    }
}