public class Solution {
    public bool IsValidSudoku(char[][] board) {
        for(int i = 0; i < 9; i++){
            HashSet<char> h = new HashSet<char>();
            for(int j = 0; j < 9; j++){
                if(board[i][j] == '.') continue;
                if(h.Contains(board[i][j])) return false;
                h.Add(board[i][j]);
            }
        }

        for(int i = 0; i < 9; i++){
            HashSet<char> h = new HashSet<char>();
            for(int j = 0; j < 9; j++){
                if(board[j][i] == '.') continue;
                if(h.Contains(board[j][i])) return false;
                h.Add(board[j][i]);
            }
        }

        for(int s = 0; s < 9; s++){
            HashSet<char> h = new HashSet<char>();
            for(int i = 0; i < 3; i++){
                for(int j = 0; j < 3; j++){
                    int row = (s / 3) * 3 + i;
                    int col = (s % 3) * 3 + j;
                    if(board[row][col] == '.') continue;
                    if(h.Contains(board[row][col])) return false;
                    h.Add(board[row][col]);
                }
            }
        }

        return true;
    }
}
