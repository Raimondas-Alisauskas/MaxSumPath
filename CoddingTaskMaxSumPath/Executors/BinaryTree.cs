namespace CoddingTaskMaxSumPath
{
    internal class BinaryTree
    {
        public BinaryTree(int[][] dataArr, int[] coordin)
        {
            this.Node = this.AddNode(dataArr, coordin);
        }

        public Node Node { get; set; }

        private Node AddNode(int[][] dataArr, int[] coordin)
        {
            var node = new Node();
            var level = coordin[0];
            var position = coordin[1];
            node.Value = dataArr[level][position];

            if (level < dataArr.Length - 1)
            {
                var leftChildValue = dataArr[level + 1][position];

                if (node.Value.Fits(leftChildValue))
                {
                    node.LeftChild = this.AddNode(dataArr, new int[] { level + 1, position });
                }

                var rightChildValue = dataArr[level + 1][position + 1];

                if (node.Value.Fits(rightChildValue))
                {
                    node.RightChild = this.AddNode(dataArr, new int[] { level + 1, position + 1 });
                }
            }

            return node;
        }
    }
}
