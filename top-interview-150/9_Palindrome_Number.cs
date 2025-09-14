// 9. Palindrome Number (Math)

// Given an integer x, return true if x is a palindrome, and false otherwise.

// (Math is very costy for CPU)

public class Solution {
    public bool IsPalindrome(int x) {
        int size;

        if(x < 0){
            return false;
        }

        size = (int)Math.Floor(Math.Log10(x)) + 1;

        if(size == 1){
            return true;
        }

        while(size > 0){
            if( (x / (int)Math.Pow(10, size - 1)) != (x % 10) ){
                return false;
            }
            x = x % (int)Math.Pow(10, size - 1);
            size -= 2;
            x = x / 10;
        }


        return true;
    }
}