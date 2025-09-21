// 36. Valid Sudoku (Matrix)

// Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:
    // Each row must contain the digits 1-9 without repetition.
    // Each column must contain the digits 1-9 without repetition.
    // Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
// Note:
    // A Sudoku board (partially filled) could be valid but is not necessarily solvable.
    // Only the filled cells need to be validated according to the mentioned rules.

public class Solution {
    private const int COLS = 9;
    private const int ROWS = 9;

    private void ResetNumbers(bool[] numbers){
        for(int i = 0; i < numbers.Length; i++){
            numbers[i] = false;
        }
    }

    public bool IsValidSudoku(char[][] board) {
        bool[] numbers = new bool[COLS];
        int tile;

        //Check rows
        for(int i = 0; i < ROWS; i++){
            for(int j = 0; j < COLS; j++){
                if(board[i][j] != '.'){
                    tile = board[i][j] - '0';
                    if(numbers[tile - 1]){
                        return false;
                    }else{
                        numbers[tile - 1] = true;
                    }
                }
            }
            ResetNumbers(numbers);
        }

        //Check columns
        for(int j = 0; j < COLS; j++){
            for(int i = 0; i < ROWS; i++){
                if(board[i][j] != '.'){
                    tile = board[i][j] - '0';
                    if(numbers[tile - 1]){
                        return false;
                    }else{
                        numbers[tile - 1] = true;
                    }
                }
            }
            ResetNumbers(numbers);
        }

        //Check sub-boxes
        for(int i = 0; i < ROWS; i++){
            for(int j = 0; j < COLS; j++){
              if(board[((i/3)*3)+j/3][((i%3)*3)+j%3] != '.'){
                    tile = board[((i/3)*3)+j/3][((i%3)*3)+j%3] - '0';
                    if(numbers[tile - 1]){
                        return false;
                    }else{
                        numbers[tile - 1] = true;
                    }
                }
            }
            ResetNumbers(numbers);
        }

        return true;
    }
}