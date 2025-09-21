// 169. Majority Element

// Given an array nums of size n, return the majority element.
// The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

public class Solution {
    public int MajorityElement(int[] nums) {
        int size = nums.Length;
        int i = 0;
        int counter = 0;
        int[] contador = new int[size];

        while(i < size){
            if(contador[i] == 0){
                counter = 0;
                for(int j = i; j < size; j++){
                    if(nums[j] == nums[i]){
                        counter++;
                        contador[j] = 1;
                    }
                }
                if(counter > size/2){
                    return nums[i];
                }
            }
            i++;
        }


        return 0;

    }
}