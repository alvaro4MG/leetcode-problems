// 27. Remove Element

// Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.
// Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:
    // Change the array nums such that the first k elements of nums contain the elements which are not equal to val. The remaining elements of nums are not important as well as the size of nums.
    // Return k.

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int i = nums.Length - 1;
        int j = 0;
        int k = 0;

        while(i >= j){
            if(nums[i] == val){
                i--;
            }else if(nums[j] == val){
                nums[j] = nums[i];
                k++;
                j++;
                i--;
            }else{
                j++;
                k++;
            }
        }

        return k;
    }
}