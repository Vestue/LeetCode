public class Solution {
    public int[] GetConcatenation(int[] nums) {
        if (nums.Length < 1 || nums.Length > 1000) return default;
        int[] arr = new int[nums.Length * 2];
        nums.CopyTo(arr, 0);
        nums.CopyTo(arr, nums.Length);
        return arr;
    }
}