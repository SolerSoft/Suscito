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
    }
}