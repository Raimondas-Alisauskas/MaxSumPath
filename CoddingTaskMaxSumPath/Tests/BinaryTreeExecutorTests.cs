namespace CoddingTaskMaxSumPath
{
    using Xunit;

    public class BinaryTreeExecutorTests
    {
        [Fact]
        public void GetMaxSumAndPath_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var executor = new BinaryTreeExecutor();
            var testDataArray = IOHelper.GetTestDataArray();
            var binaryTree = new BinaryTree(testDataArray, new int[] { 0, 0 });

            // Act
            executor.GetMaxSumAndPath(binaryTree);
            int maxSum = executor.MaxSum;
            string path = executor.MaxPath;

            // Assert
            Assert.Equal(16, maxSum);
            Assert.Equal("1, 8, 5, 2", path);
        }
    }
}
