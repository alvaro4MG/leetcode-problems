// 54. Spiral Matrix

// Given an m x n matrix, return all elements of the matrix in spiral order.

public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        List<int> spiral = new List<int>();
        int count = matrix.Length * matrix[0].Length;

        int top = 0;
        int bottom = matrix.Length - 1;
        int left = 0;
        int right = matrix[0].Length - 1;

        while (top <= bottom && left <= right && count > 0) {
            
            for (int col = left; col <= right && count > 0; col++) {
                spiral.Add(matrix[top][col]);
                count--;
            }
            top++;

            for (int row = top; row <= bottom && count > 0; row++) {
                spiral.Add(matrix[row][right]);
                count--;
            }
            right--;

            for (int col = right; col >= left && count > 0; col--) {
                spiral.Add(matrix[bottom][col]);
                count--;
            }
            bottom--;

            for (int row = bottom; row >= top && count > 0; row--) {
                spiral.Add(matrix[row][left]);
                count--;
            }
            left++;
        }

        return spiral;
    }
}
