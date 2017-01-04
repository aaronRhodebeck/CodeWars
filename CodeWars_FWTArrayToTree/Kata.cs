using System.Collections.Generic;

public class Solution
{
    public static TreeNode ArrayToTree(int[] array)
    {
        var values = new Queue<int>(array);
        return CreateLevel(values, new Queue<TreeNode>());
    }

    private static TreeNode CreateLevel(Queue<int> values, Queue<TreeNode> levelNodes)
    {
        var nextLevel = new Queue<TreeNode>();
        if (levelNodes.Count == 0 && values.Count != 0)
        {
            var rootNode = new TreeNode(values.Dequeue(), 
                                        new TreeNode(values.Dequeue()),
                                        new TreeNode(values.Dequeue()));
            nextLevel.Enqueue(rootNode.left);
            nextLevel.Enqueue(rootNode.right);
            CreateLevel(values, nextLevel);
            return rootNode;
        }
        else
        {
            while (values.Count != 0 && levelNodes.Count != 0)
            {
                var currentNode = levelNodes.Dequeue();
                currentNode.left = new TreeNode(values.Dequeue());
                currentNode.right = new TreeNode(values.Dequeue());
                nextLevel.Enqueue(currentNode.left);
                nextLevel.Enqueue(currentNode.right);
            }
            if (values.Count != 0)
            {
                CreateLevel(values, nextLevel);
            }
        }
        return null;
    }



    public class TreeNode {

        public TreeNode left;
        public TreeNode right;
        public int value;

        public TreeNode(int value, TreeNode left, TreeNode right)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }

        public TreeNode(int value) 
        {
            this.value = value;
        }

    }

}
