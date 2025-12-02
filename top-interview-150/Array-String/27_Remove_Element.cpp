// 27. Remove Element

// Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.
// Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:
    // Change the array nums such that the first k elements of nums contain the elements which are not equal to val. The remaining elements of nums are not important as well as the size of nums.
    // Return k.

class Solution {
private:
    void swap(vector<int>& nums, int left, int right){
        int aux = nums[right];
        nums[right] = nums[left];
        nums[left] = aux;
    }
public:
    int removeElement(vector<int>& nums, int val) {
        int i = 0;
        int max = nums.size() - 1;

        while(i <= max){
            if(nums[i] == val){
                //std::swap(nums[i], nums[max]);
                swap(nums, i, max);
                max--;
            }else{
                i++;
            }
        }

        return i;
    }
};