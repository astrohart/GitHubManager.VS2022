namespace GitHubManager
{
    /// <summary>
    /// Helper methods for integer variables.
    /// </summary>
    public static class IntExtensions
    {
        /// <summary>
        /// Determines whether a bitmask is 'on' or 'off'.
        /// </summary>
        /// <param name="num">(Required.) Value containing the data to be checked.</param>
        /// <param name="bitmask">(Required.) Bitmask.</param>
        /// <returns>
        /// <see langword="true" /> if the bit that is identified by the bitmask
        /// in the data is 'on'; <see langword="false" /> if it is not.
        /// </returns>
        public static bool IsBitmaskOn(this int num, int bitmask)
            => (num & bitmask) != 0;
    }
}