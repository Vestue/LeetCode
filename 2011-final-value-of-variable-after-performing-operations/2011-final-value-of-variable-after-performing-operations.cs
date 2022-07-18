public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int val = 0;
        foreach (string op in operations)
        {
            if (op.Equals("++X") || op.Equals("X++")) val++;
            else val--;
        }
        return val;
    }
}