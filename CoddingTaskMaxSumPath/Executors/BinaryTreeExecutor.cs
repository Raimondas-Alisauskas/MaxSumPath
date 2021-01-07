namespace CoddingTaskMaxSumPath
{
    internal class BinaryTreeExecutor
    {
        public int MaxSum { get; set; } = int.MinValue;

        public string MaxPath { get; set; } = string.Empty;

        public void GetMaxSumAndPath(BinaryTree tree)
        {
            tree.Node.Path = $"{tree.Node.Value}";
            this.TraverseTree(tree.Node);
        }

        private void TraverseTree(Node node)
        {
            var leftChild = node.LeftChild;
            if (leftChild != null)
            {
                leftChild.Path = $"{node.Path}, {leftChild.Value}";
                leftChild.Value += node.Value;

                this.TraverseTree(leftChild);

                if (this.MaxSum < leftChild.Value)
                {
                    this.MaxSum = leftChild.Value;
                    this.MaxPath = leftChild.Path;
                }
            }

            var rightChild = node.RightChild;
            if (rightChild != null)
            {
                rightChild.Path = $"{node.Path}, {rightChild.Value}";
                rightChild.Value += node.Value;

                this.TraverseTree(rightChild);

                if (this.MaxSum < rightChild.Value)
                {
                    this.MaxSum = rightChild.Value;
                    this.MaxPath = rightChild.Path;
                }
            }
        }
    }
}