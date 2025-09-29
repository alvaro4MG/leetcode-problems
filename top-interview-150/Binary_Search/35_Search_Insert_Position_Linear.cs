// 35. Search Insert Position [Linear complexity]

// Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
// You must write an algorithm with O(log n) runtime complexity.

// NOT THE REAL SOLUTION

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int size = nums.Length;
        int i = 0;

        if(size == 1){
            if(nums[i] < target){
                i++;
            }
            return i;
        }

        for(i = 0; i < size; i++){
            if(nums[i] >= target){
                return i;
            }
        }

        return i;

    }
}