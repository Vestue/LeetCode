/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
  public TreeNode SortedArrayToBST(int[] nums) {
    return recursiveConvert(0, nums.Length - 1, nums);
  }

  private TreeNode? recursiveConvert (int left, int right, int[] nums){
    if (left > right) return null;

    int mid = left + ((right - left) / 2);
    TreeNode node = new TreeNode(nums[mid]);
    node.right = recursiveConvert(mid + 1, right, nums);
    node.left = recursiveConvert(left, mid - 1, nums);

    return node;
  }
}