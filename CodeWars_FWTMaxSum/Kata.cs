namespace Tree
{

    class Solution
  {
      public static int MaxSum(TreeNode root)
      {
          if (root == null)
          {
              return 0;
          }
          return SumEachRouteReturnHighest(root, 0);
      }

      private static int SumEachRouteReturnHighest(TreeNode current, int sumOfRoute)
      {
          int sumOfRightBranch;
          int sumOfLeftBranch;
          
          if (current == null)
          {
              return 0;
          }
          else if (current.left == null && current.right == null)
          {
              sumOfRoute = current.value;
          }
          else 
          {
              sumOfRightBranch = SumEachRouteReturnHighest(current.right, sumOfRoute);
              sumOfLeftBranch = SumEachRouteReturnHighest(current.left, sumOfRoute);
              
              sumOfRoute = (sumOfRightBranch >= sumOfLeftBranch) ? 
                                 current.value + sumOfRightBranch : current.value + sumOfLeftBranch;
          }
          return sumOfRoute;        
      }
   }
}