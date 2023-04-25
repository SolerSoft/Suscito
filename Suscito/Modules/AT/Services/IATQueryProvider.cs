namespace Suscito.Modules.AT
{
    /// <summary>
    /// A service that can execute Attachment Theory queries.
    /// </summary>
    public interface IATQueryProvider
    {
		/// <summary>
		/// Get a default title for the query.
		/// </summary>
		/// <param name="query">
		/// The query to obtain a title for.
		/// </param>
		/// <returns>
		/// A title for the query or <see langword = "null" /> if no 
        /// title could be determined.
		/// </returns>
		string? GetTitle(string query);

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