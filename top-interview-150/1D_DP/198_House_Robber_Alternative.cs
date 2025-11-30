// 198. House Robber

// You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed, the only constraint stopping you from robbing each of them is that adjacent houses have security systems connected and it will automatically contact the police if two adjacent houses were broken into on the same night.
// Given an integer array nums representing the amount of money of each house, return the maximum amount of money you can rob tonight without alerting the police.

// MORE OPTIMAL SOLUTION, no Dictionary

public class Solution {
    public int Rob(int[] nums) {
        int rob1 = 0;
        int rob2 = 0;

        foreach (int n in nums) {
            int newRob = Math.Max(rob1, rob2 + n);
            rob2 = rob1;
            rob1 = newRob;
        }

        return rob1;
    }
}