// 172. Factorial Trailing Zeroes

// Given an integer n, return the number of trailing zeroes in n!.
// Note that n! = n * (n - 1) * (n - 2) * ... * 3 * 2 * 1.

// NOT SOLUTION YET, DOESN'T WORK FROM n=50

public class Solution {
    public int TrailingZeroes(int n) {
        
        if(n == 0){
            return 0;
        }

        int number = 1;
        int counter = 0;

        for(int i = 1; i <= n; i++){
            number = number * i;
            if(number > 10000000){
                number = number % 10000000;
            }
            if(number % 10 == 0){
                counter++;
                number = number / 10;
            }
        }
        
        return counter;
    }
}