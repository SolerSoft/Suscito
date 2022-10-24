namespace Suscito.Modules.AT.Entities;

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
/// Provides information about a <see cref="BowlbyStyle" />.
/// </summary>
public class BowlbyStyleInfo : StyleInfo<BowlbyStyle>
{
    #region Static Version

    #region Public Properties

    /// <summary>
    /// Gets info for the <see cref="BowlbyStyle.Anxious">Anxious</see> style.
    /// </summary>
    public static BowlbyStyleInfo Anxious => GetOrCreateInfo(BowlbyStyle.Anxious, () => new BowlbyStyleInfo(BowlbyStyle.Anxious));

    /// <summary>
    /// Gets info for the <see cref="BowlbyStyle.Avoidant">Avoidant</see> style.
    /// </summary>
    public static BowlbyStyleInfo Avoidant => GetOrCreateInfo(BowlbyStyle.Avoidant, () => new BowlbyStyleInfo(BowlbyStyle.Avoidant));

    /// <summary>
    /// Gets info for the <see cref="BowlbyStyle.Disorganized">Disorganized</see> style.
    /// </summary>
    public static BowlbyStyleInfo Disorganized => GetOrCreateInfo(BowlbyStyle.Disorganized, () => new BowlbyStyleInfo(BowlbyStyle.Disorganized));

    /// <summary>
    /// Gets info for the <see cref="BowlbyStyle.Secure">Secure</see> style.
    /// </summary>
    public static BowlbyStyleInfo Secure => GetOrCreateInfo(BowlbyStyle.Secure, () => new BowlbyStyleInfo(BowlbyStyle.Secure));

    /// <summary>
    /// Gets info for the <see cref="BowlbyStyle.Unknown">Unknown</see> style.
    /// </summary>
    public static BowlbyStyleInfo Unknown => GetOrCreateInfo(BowlbyStyle.Unknown, () => new BowlbyStyleInfo(BowlbyStyle.Unknown));

    #endregion Public Properties

    #endregion // Static Version



    #region Instance Version

    #region Public Constructors

    /// <summary>
    /// Initializes a new <see cref="BowlbyStyleInfo" />.
    /// </summary>
    /// <param name="style">
    /// The underlying style.
    /// </param>
    public BowlbyStyleInfo(BowlbyStyle style) : base(style) { }

    #endregion Public Constructors

    #region Public Properties

    /// <inheritdoc />
    public override string AKA
    {
        get
        {
            switch (Style)
            {
                case BowlbyStyle.Anxious:
                    return "Preoccupied, Open Heart";

                case BowlbyStyle.Avoidant:
                    return "Dismissive Avoidant, DA, Rolling Stone";

                case BowlbyStyle.Disorganized:
                    return "Fearful Avoidant, FA, Spice of Lifer";

                case BowlbyStyle.Secure:
                    return "Cornerstone";

                case BowlbyStyle.Unknown:
                default:
                    return "Unknown";
            }
        }
    }

    /// <inheritdoc />
    public override string Description
    {
        get
        {
            switch (Style)
            {
                case BowlbyStyle.Anxious:
                    return "People with this style have higher levels of anxiety when they are alone. They value " +
                        "relationships highly, but often worry that their partner is not as invested as they are.";

                case BowlbyStyle.Avoidant:
                    return "People with this style often feel they don’t need relationship to feel complete. They are " +
                        "fiercely independent and are uncomfortable when others depend on them or seek their approval.";

                case BowlbyStyle.Disorganized:
                    return "People with this style want intimacy and closeness but are also afraid of them. " +
                        "Relationships and their partner can trigger confusing feelings of both desire and fear.";

                case BowlbyStyle.Secure:
                    return "People with this style are comfortable depending on their partners and letting their " +
                        "partners depend on them. They are comfortable with honesty and emotional intimacy.";

                case BowlbyStyle.Unknown:
                default:
                    return "Unknown";
            }
        }
    }

    /// <inheritdoc />
    public override string LearnMoreUrl
    {
        get
        {
            switch (Style)
            {
                case BowlbyStyle.Anxious:
                    return "https://www.attachmentproject.com/blog/anxious-attachment";

                case BowlbyStyle.Avoidant:
                    return "https://www.attachmentproject.com/blog/avoidant-attachment-style";

                case BowlbyStyle.Disorganized:
                    return "https://www.attachmentproject.com/blog/disorganized-attachment";

                case BowlbyStyle.Secure:
                    return "https://www.attachmentproject.com/blog/secure-attachment";

                case BowlbyStyle.Unknown:
                default:
                    return "https://www.attachmentproject.com/attachment-theory";
            }
        }
    }

    /// <inheritdoc />
    public override string Name => Style.ToString();

    #endregion Public Properties

    #endregion // Instance Version
}