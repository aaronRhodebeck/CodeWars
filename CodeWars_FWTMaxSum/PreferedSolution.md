namespace Tree 
{
  class Solution
  {
      public static int MaxSum(TreeNode root)
      {
          return root == null ? 0 :
            root.value + Math.Max(MaxSum(root.left), MaxSum(root.right));
      }
  }
}