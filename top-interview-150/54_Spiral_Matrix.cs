// 54. Spiral Matrix

// Given an m x n matrix, return all elements of the matrix in spiral order.

public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        List<int> spiral = new List<int>();
        int[] operators = {1, 1, -1, -1};
        int offset = matrix.GetLength(0) - 1;
        int row = 0;
        int column = 0;

        // first row
        // last column
        // reverse last row

        //signs of operations: +, +, -, -
        // quantities: L-1, l-1, l-1, l-2,l-2...l-3,l-3
        // 3 veces enteras, 2 veces con 1 menos...

        while(offset > 0){
            for(int i = 0; i <= offset; i++){
                spiral.Add(matrix[row][i]);
            }
            offset--;
        }

        return spiral;

    }
}