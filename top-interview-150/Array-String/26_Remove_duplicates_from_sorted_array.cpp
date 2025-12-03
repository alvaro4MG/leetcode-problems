// 26. Remove Duplicates from Sorted Array

// Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same.
// Consider the number of unique elements in nums to be k​​​​​​​​​​​​​​. After removing duplicates, return the number of unique elements k.
// The first k elements of nums should contain the unique numbers in sorted order. The remaining elements beyond index k - 1 can be ignored.

class Solution {
public:
    int removeDuplicates(vector<int>& nums) {
        int i = 1;
        int last = 0;

        if(nums.size() == 1){
            return 1;
        }

        while(i < nums.size()){
            if(nums[i] == nums[last]){
                i++;
            }else{
                last++;
                nums[last] = nums[i];
            }
        }
        last++;

        return last;
    }
};