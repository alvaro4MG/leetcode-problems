// 190. Reverse Bits

// Reverse bits of a given 32 bits signed integer.

public class Solution {
    private const int BITS = 32;

    /*private int maxBit(int n){
        int max = 0;
        
        while(n > 0){
            n = n / 2;
            max++;
        }
        max++;
        return max;
    }*/

    public int ReverseBits(int n) {
        
        int i = 0;
        uint reverse = 0;
        //int bit = 0;
        //int size = maxBit(n);
        uint num = (uint)n;

        while(i < BITS){
            uint bit = num & 1;

            reverse <<= 1;
            reverse |= bit;

            num >>= 1;
            i++;
        }

        return (int)reverse;

    }
}