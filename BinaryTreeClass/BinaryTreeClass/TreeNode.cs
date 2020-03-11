using System;

namespace BinaryTreeClass
{
    public class TreeNode
    {
        public TreeNode LeftNode { get; set; }
        public IComparable Data { get; private set; }
        public TreeNode RightNode { get; set; }

        public TreeNode(IComparable nodeData)
        {
            Data = nodeData;
        }

        //INSERT NODE
        public void Insert(IComparable insertValue)
        {
            if (insertValue.CompareTo(Data) < 0)
            {
                if (LeftNode == null)
                {
                    LeftNode = new TreeNode(insertValue);
                }
                else
                {
                    LeftNode.Insert(insertValue);
                }

            }
            else if(insertValue.CompareTo(Data) > 0)
            {
                if (RightNode == null)
                {
                    RightNode = new TreeNode(insertValue);
                }
                else
                {
                    RightNode.Insert(insertValue);
                }
            }
        }
    }//End TreeNode Class
    public class Tree
    {
        private TreeNode root;

        public void InsertNode(IComparable insertValue)
        {
            if (root == null)
            {
                root = new TreeNode(insertValue);
            }
            else
            {
                root.Insert(insertValue);
            }
        }
        //PREORDER
        private void PreorderHelper(TreeNode node)
        {
            if (node != null)
            {
                Console.Write($"{node.Data} ");
                PreorderHelper(node.LeftNode);
                PreorderHelper(node.RightNode);
            }
        }
        //INORDER
        private void InorderHelper(TreeNode node)
        {
            if (node != null)
            {
                InorderHelper(node.LeftNode);
                Console.Write($"{node.Data} ");
                InorderHelper(node.RightNode);
            }
        }
        //POSTORDER
        private void PostorderHelper(TreeNode node)
        {
            if (node != null)
            {
                PostorderHelper(node.LeftNode);
                PostorderHelper(node.RightNode);
                Console.Write($"{node.Data} ");
            }
        }
        /*
         * 
         * Traversal Methods
         * 
         */
         public void PreorderTraversal()
        {
            PreorderHelper(root);
        }
        public void InorderTraversal()
        {
            InorderHelper(root);
        }
        public void PostorderTraversal()
        {
            PostorderHelper(root);
        }

    }//End Tree Class
}//End Namespace
