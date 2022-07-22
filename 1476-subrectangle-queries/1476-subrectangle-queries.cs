public class SubrectangleQueries {
    private int[][] _rect;

    public SubrectangleQueries(int[][] rectangle) {
        _rect = rectangle;
    }
    
    public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue) {
        for (int r = row1; r <= row2; r++)
        {
            for (int c = col1; c <= col2; c++)
            {
                _rect[r][c] = newValue;
            }
        }
    }
    
    public int GetValue(int row, int col) {
        return _rect[row][col];
    }
}

/**
 * Your SubrectangleQueries object will be instantiated and called as such:
 * SubrectangleQueries obj = new SubrectangleQueries(rectangle);
 * obj.UpdateSubrectangle(row1,col1,row2,col2,newValue);
 * int param_2 = obj.GetValue(row,col);
 */