// 172. Factorial Trailing Zeroes

// Given an integer n, return the number of trailing zeroes in n!.
// Note that n! = n * (n - 1) * (n - 2) * ... * 3 * 2 * 1.

// NOT SOLUTION YET, DOESN'T WORK FROM n=50

public class Solution {
    public int TrailingZeroes(int n) {
        
        if(n == 0){
            return 0;
        }

        int counter = 0;

        while(n > 0){
            counter += n / 5;
            n = n / 5;
        }

        return counter;
    }
}