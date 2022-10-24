namespace Suscito.Modules.AT
{
    /// <summary>
    /// Provides information about a variant of an Attachment Theory style.
    /// </summary>
    public abstract class StyleInfo
    {
        #region Public Properties

        /// <summary>
        /// Gets a string of "Also Known As" descriptions for the style.
        /// </summary>
        public abstract string AKA { get; }

        /// <summary>
        /// Gets a description for the style.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Gets the URL where more can be learned about the style.
        /// </summary>
        public abstract string LearnMoreUrl { get; }

        /// <summary>
        /// Gets a name for the style.
        /// </summary>
        public abstract string Name { get; }

        #endregion Public Properties
    }

    /// <summary>
    /// Provides information about a variant of an Attachment Theory style.
    /// </summary>
    /// <typeparam name="TStyle">
    /// The enum that represents the style types.
    /// </typeparam>
    public abstract class StyleInfo<TStyle> : StyleInfo where TStyle : Enum
    {
        #region Static Version

        #region Private Fields

        private static Dictionary<TStyle, StyleInfo<TStyle>> s_infoCache;

        #endregion Private Fields

        #region Private Methods

        /// <summary>
        /// Gets a previously created style info if it's already been created, otherwise creates and caches it.
        /// </summary>
        /// <param name="style">
        /// The style to get.
        /// </param>
        /// <param name="creator">
        /// The method to call to create the info if not found.
        /// </param>
        /// <returns>
        /// The style info.
        /// </returns>
        protected static TStyleInfo GetOrCreateInfo<TStyleInfo>(TStyle style, Func<TStyleInfo> creator) where TStyleInfo : StyleInfo<TStyle>
        {
            // Ensure the cache exists
            if (s_infoCache == null) { s_infoCache = new Dictionary<TStyle, StyleInfo<TStyle>>(); }

            // Placeholder
            StyleInfo<TStyle> info;

            // Try to get the existing
            if (!s_infoCache.TryGetValue(style, out info))
            {
                // Existing not found, create and add
                info = creator();
                s_infoCache[style] = info;
            }

            // Done!
            return (TStyleInfo)info;
        }

        #endregion Private Methods

        #endregion // Static Version



        #region Instance Version

        #region Public Constructors

        /// <summary>
        /// Initializes a new <see cref="StyleInfo" />.
        /// </summary>
        /// <param name="style">
        /// The underlying style being represented.
        /// </param>
        public StyleInfo(TStyle style)
        {
            Style = style;
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// Gets the style for which information is being provided.
        /// </summary>
        public TStyle Style { get; private set; }

        #endregion Public Properties

        #endregion // Instance Version
    }
}