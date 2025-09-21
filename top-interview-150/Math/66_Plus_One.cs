// 66. Plus One (Math)

// You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.
// Increment the large integer by one and return the resulting array of digits.

public class Solution {
    public int[] PlusOne(int[] digits) {
        int size = digits.Length;
        bool plusOne = true;

        for(int i = (size - 1); plusOne && i >= 0; i--){
            if(digits[i] == 9){
                digits[i] = 0;
                if(i == 0){
                    int[] additional = new int[size + 1];
                    additional[0] = 1;
                    Array.Copy(digits, 0, additional, 1, size);
                    return additional;
                }
            }else{
                digits[i] += 1;
                plusOne = false;
            }
            
        }

        return digits;
    }
}