namespace CoddingTaskMaxSumPath
{
    public static class IntExtensions
    {
        public static bool Fits(this int parent, int child)
        {
            if ((parent - child) % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
