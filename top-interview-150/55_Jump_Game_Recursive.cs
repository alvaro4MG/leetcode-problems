// 55. Jump Game (Recursive solution)

// You are given an integer array nums. You are initially positioned at the array's first index, and each element in the array represents your maximum jump length at that position.
// Return true if you can reach the last index, or false otherwise.

// SOLUTION ONLY VALID FOR SMALL CASES

public class Solution {

    private bool CanJumpRecursive(int[] nums, int index, int size){
        
        if(index == size){
            return true;
        }else if(index > size){
            return false;
        }

        for(int i = nums[index]; i > 0; i--){
            if(CanJumpRecursive(nums, (index + i), size) ){
                return true;
            }
        }
        return false;
    }

    public bool CanJump(int[] nums) {
        int size = nums.Length - 1;
        
        if(nums.Length < 2){
            return true;
        }
        
        return CanJumpRecursive(nums,0,size);
    }
}