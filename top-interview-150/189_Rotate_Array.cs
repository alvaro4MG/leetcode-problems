// 189. Rotate Array (Array / String)

// Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.

public class Solution {

    private void Swap(int[] nums, int first, int last){
        int aux = 0;

        while(first < last){
            aux = nums[first];
            nums[first] = nums[last];
            nums[last] = aux;

            first++;
            last--;
        }

    }

    public void Rotate(int[] nums, int k) {     //to the right
        int size = nums.Length;

        k = k % size;

        Swap(nums, 0, size - k - 1);
        Swap(nums, size - k, size - 1);
        Swap(nums, 0, size - 1);

    }
}