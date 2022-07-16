public class Solution {
    public int[] RunningSum(int[] nums) {
        int[] arr = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                arr[i] += nums[j];
            }
        }
        return arr;
    }
}