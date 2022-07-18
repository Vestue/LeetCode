public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int highestWealth = 0, currWealth;
        for (int i = 0; i < accounts.Length; i++)
        {
            currWealth = 0;
            for (int j = 0; j < accounts[i].Length; j++) currWealth += accounts[i][j];
            if (currWealth > highestWealth) highestWealth = currWealth;
        }
        return highestWealth;
    }
}