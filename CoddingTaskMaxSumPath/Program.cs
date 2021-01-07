namespace CoddingTaskMaxSumPath
{
    internal static class Program
    {
        private static void Main()
        {
            var initDataArray = IOHelper.GetInitDataArray();

            var initCoordinates = new int[] { 0, 0 };
            var binaryTree = new BinaryTree(initDataArray, initCoordinates);

            BinaryTreeExecutor executor = new BinaryTreeExecutor();

            executor.GetMaxSumAndPath(binaryTree);
            int maxSum = executor.MaxSum;
            string path = executor.MaxPath;

            IOHelper.LogInitialData(initDataArray);
            IOHelper.LogMaxSumResults(maxSum, path);
        }
    }
}
