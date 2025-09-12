// 45. Jump Game II (Array / String)

// You are given a 0-indexed array of integers nums of length n. You are initially positioned at index 0.
// Each element nums[i] represents the maximum length of a forward jump from index i. In other words, if you are at index i, you can jump to any index (i + j) where:
    // 0 <= j <= nums[i] and
    // i + j < n
// Return the minimum number of jumps to reach index n - 1. The test cases are generated such that you can reach index n - 1.

public class Solution {
    public int Jump(int[] nums) {
        int maxReach = 0;
        int[] range = [0,0];    //experiment with range
        int jumps = 0;

        if(nums.Length <= 2){
            return (nums.Length - 1);
        }

        range = [1, nums[0]];

        //while(maxReach < nums.Length){}
        
        for(int i = 0; maxReach < (nums.Length - 1) && i < nums.Length; i++){
            jumps++;
            while(i < nums.Length && i < range[1]){
                maxReach = Math.Max(maxReach, i + nums[i]);
                i++;
            }
            
        }

        return jumps;
    }
}