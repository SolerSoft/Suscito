using Suscito.Modules.AT.Resources;

namespace Suscito.Modules.AT.Entities
{
    /// <summary>
    /// The core attachment styles attributed to <see href="https://en.wikipedia.org/wiki/John_Bowlby">John Bowlby</see>.
    /// </summary>
    public enum BowlbyStyle
    {
        Unknown,
        Anxious,
        Avoidant,
        Disorganized,
        Secure
    }

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
    public class StyleInfo<TStyle> : StyleInfo where TStyle : Enum
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

        #region Private Methods

        /// <summary>
        /// Gets the name of the resource with the specified suffix.
        /// </summary>
        /// <param name="suffix">
        /// The suffix to add to the resource name.
        /// </param>
        /// <returns>
        /// The fully qualified name of the resource.
        /// </returns>
        private string GetResourceName(string suffix)
        {
            return $"{typeof(TStyle).Name}.{Enum.GetName(typeof(TStyle), Style)}.{suffix}";
        }

        /// <summary>
        /// Gets a string resource with the specified suffix.
        /// </summary>
        /// <param name="suffix">
        /// The suffix of the string resource.
        /// </param>
        /// <returns>
        /// The string resource.
        /// </returns>
        private string GetString(string suffix)
        {
            // Get the resource name
            string resName = GetResourceName(suffix);

            // Get the string
            return ATStyleRes.ResourceManager.GetString(resName);
        }

        #endregion Private Methods

        #region Public Properties

        /// <inheritdoc />
        public override string AKA => GetString(nameof(AKA));

        /// <inheritdoc />
        public override string Description => GetString(nameof(Description));

        /// <inheritdoc />
        public override string LearnMoreUrl => GetString(nameof(LearnMoreUrl));

        /// <inheritdoc />
        public override string Name => GetString(nameof(Name));

        /// <summary>
        /// Gets the style for which information is being provided.
        /// </summary>
        public TStyle Style { get; private set; }

        #endregion Public Properties
    }
}