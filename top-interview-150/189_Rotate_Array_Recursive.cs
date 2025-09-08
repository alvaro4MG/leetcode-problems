// 189. Rotate Array [Recursive solution] (Array / String)

// Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.

// SOLUTION NOT VALID FOR BIGGER CASES

public class Solution {
    public void Rotate(int[] nums, int k) {     //to the right
        int size = nums.Length;
        int last = nums[size - 1];

        k = k % size;

        if(k != 0){
            for (int i = size - 1; i > 0; i--){
                nums[i] = nums[i - 1];
            }
            nums[0] = last;
            Rotate(nums, (k - 1) );
        }


    }
}