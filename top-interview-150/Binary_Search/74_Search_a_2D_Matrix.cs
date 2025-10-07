// 74. Search a 2D Matrix

// You are given an m x n integer matrix matrix with the following two properties:
    // Each row is sorted in non-decreasing order.
    // The first integer of each row is greater than the last integer of the previous row.
// Given an integer target, return true if target is in matrix or false otherwise.
// You must write a solution in O(log(m * n)) time complexity.

public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int upperRow = 0;
        int downRow = matrix.Length - 1;
        int mid;

        if(downRow > 0){
            while(upperRow <= downRow){
                mid = upperRow + (downRow - upperRow) / 2;

                if(matrix[mid][0] == target){
                    return true;
                }else if(matrix[mid][0] < target){
                    upperRow = mid + 1;
                }else{
                    downRow = mid - 1;
                }
            }
        }else{
            upperRow = 1;
        }

        int row = Math.Max(0, upperRow - 1);
        if(row >= matrix.Length){
            row = matrix.Length - 1;
        }
        int left = 0;
        int right = matrix[0].Length - 1;

        while(left <= right){
            mid = left + (right - left) / 2;

            if(matrix[row][mid] == target){
                return true;
            }else if(matrix[row][mid] < target){
                left = mid + 1;
            }else{
                right = mid - 1;
            }
        }

        return false;

    }
}