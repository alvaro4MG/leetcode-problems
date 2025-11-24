// 191. Number of 1 Bits

// Given a positive integer n, write a function that returns the number of set bits in its binary representation (also known as the Hamming weight).

public class Solution {
    public int HammingWeight(int n) {
        int counter = 0;

        while(n > 0){
            if((n & 1) == 1){
                counter++;
            }

            n >>= 1;
        }

        return counter;
    }
}