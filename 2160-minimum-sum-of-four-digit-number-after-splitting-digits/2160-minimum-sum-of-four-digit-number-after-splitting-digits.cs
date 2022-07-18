public class Solution {
    public int MinimumSum(int num) {
        int[] arr = new int[4];
        for (int i = 0; i < 4; i++)
        {
            arr[i] = (num % (int)Math.Pow(10, i + 1)) / (int)Math.Pow(10, i);
        }
        Array.Sort(arr);
        int result = arr[0] * 10 + arr[1] * 10 + arr[2] + arr[3];
        return result;
    }
}