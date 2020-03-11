using System;

namespace Generic_Binary_Tree_MKII
{
    public class TreeNode<T> where T : IComparable
    {
        public TreeNode<T> LeftNode { get; set; }
        public TreeNode<T> RightNode { get; set; }
        public IComparable Data { get; private set; }

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
                    LeftNode = new TreeNode<T>(insertValue);
                }
                else
                {
                    LeftNode.Insert(insertValue);
                }
            }
            else if (insertValue.CompareTo(Data) > 0)
            {
                if (RightNode == null)
                {
                    RightNode = new TreeNode<T>(insertValue);
                }
                else
                {
                    RightNode.Insert(insertValue);
                }
            }
        }

    } //END TREENODE CLASS

    public class Tree<T> where T : IComparable
    {
        private TreeNode<T> root;
        public void InsertNode(IComparable insertValue)
        {
            if (root == null)
            {
                root = new TreeNode<T>(insertValue);
            }
            else
            {
                root.Insert(insertValue);
            }
        }
    }
}
