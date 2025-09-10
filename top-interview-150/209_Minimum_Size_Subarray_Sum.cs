// 209. Minimum Size Subarray Sum

// Given an array of positive integers nums and a positive integer target, return the minimal length of a subarray whose sum is greater than or equal to target. If there is no such subarray, return 0 instead.

public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int i = 0;
        int j = 1;
        int minSize = 0;
        int sum = 0;

        if(nums.Length == 0){
            return 0;
        }
        if(nums[i] >= target){
            return 1;
        }
        if(nums.Length == 1){
            return 0;
        }
        sum = nums[i] + nums[j];

        while(j < nums.Length){
            while(sum >= target){
                if( (minSize == 0) || (j - i + 1) < minSize){
                    minSize = j - i + 1;
                }
                sum -= nums[i];
                i++; 
            }
            j++;
            if(j < nums.Length){
                sum += nums[j];
            }
        }


        return minSize;
    }
}