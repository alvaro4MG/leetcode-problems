// 198. House Robber

// You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed, the only constraint stopping you from robbing each of them is that adjacent houses have security systems connected and it will automatically contact the police if two adjacent houses were broken into on the same night.
// Given an integer array nums representing the amount of money of each house, return the maximum amount of money you can rob tonight without alerting the police.

public class Solution {

    private int size;

    private int recursiveRob(int[] nums, int i){


        if(i >= (size - 2)){
            return nums[i];
        }

        return nums[i] + recursiveRob(nums, i+2);
    }


    public int Rob(int[] nums) {
        size = nums.Length;

        if(size == 1){
            return nums[0];
        }

        return Math.Max(recursiveRob(nums, 0), recursiveRob(nums,1));

    }
}