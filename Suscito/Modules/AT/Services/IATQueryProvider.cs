namespace Suscito.Modules.AT
{
    /// <summary>
    /// A service that can execute Attachment Theory queries.
    /// </summary>
    public interface IATQueryProvider
    {
        /// <summary>
        /// Evaluates whether the specified query is true.
        /// </summary>
        /// <param name="query">
        /// The query to evaluate.
        /// </param>
        /// <c>true</c> if the query evaluates to true; otherwise <c>false</c>.
        bool IsTrue(string query);
    }
}