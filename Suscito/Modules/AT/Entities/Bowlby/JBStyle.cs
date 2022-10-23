using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suscito.Modules.AT;


/// <summary>
/// The core attachment styles attributed to <see href="https://en.wikipedia.org/wiki/John_Bowlby">John Bowlby</see>.
/// </summary>
public enum JBStyle
{
    Unknown,
    Anxious,
    Avoidant,
    Disorganized,
    Secure
}

/// <summary>
/// Provides information about a <see cref="JBStyle"/>.
/// </summary>
public class JBStyleInfo : StyleInfo<JBStyle>
{
    /// <summary>
    /// Initializes a new <see cref="JBStyleInfo"/>.
    /// </summary>
    /// <param name="style">
    /// The underlying style.
    /// </param>
    public JBStyleInfo(JBStyle style) : base(style) { }

    /// <inheritdoc/>
    public override string AKA
    {
        get
        {
            switch (Style)
            {
                case JBStyle.Anxious:
                    return "Preoccupied, Open Heart";

                case JBStyle.Avoidant:
                    return "Dismissive Avoidant, DA, Rolling Stone";

                case JBStyle.Disorganized:
                    return "Fearful Avoidant, FA, Spice of Lifer";

                case JBStyle.Secure:
                    return "Cornerstone";

                case JBStyle.Unknown:
                default:
                    return "Unknown";
            }
        }
    }

    /// <inheritdoc/>
    public override string Description
    {
        get
        {
            switch (Style)
            {
                case JBStyle.Anxious:
                    return "People with this style have higher levels of anxiety when they are alone. They value " +
                        "relationships highly, but often worry that their partner is not as invested as they are.";

                case JBStyle.Avoidant:
                    return "People with this style often feel they don’t need relationship to feel complete. They are " +
                        "fiercely independent and are uncomfortable when others depend on them or seek their approval.";

                case JBStyle.Disorganized:
                    return "People with this style want intimacy and closeness but are also afraid of them. " +
                        "Relationships and their partner can trigger confusing feelings of both desire and fear.";

                case JBStyle.Secure:
                    return "People with this style are comfortable depending on their partners and letting their " +
                        "partners depend on them. They are comfortable with honesty and emotional intimacy.";

                case JBStyle.Unknown:
                default:
                    return "Unknown";
            }
        }
    }


    /// <inheritdoc/>
    public override string LearnMoreUrl
    {
        get
        {
            switch (Style)
            {
                case JBStyle.Anxious:
                    return "https://www.attachmentproject.com/blog/anxious-attachment";

                case JBStyle.Avoidant:
                    return "https://www.attachmentproject.com/blog/avoidant-attachment-style";

                case JBStyle.Disorganized:
                    return "https://www.attachmentproject.com/blog/disorganized-attachment";

                case JBStyle.Secure:
                    return "https://www.attachmentproject.com/blog/secure-attachment";

                case JBStyle.Unknown:
                default:
                    return "https://www.attachmentproject.com/attachment-theory";
            }
        }
    }

    /// <inheritdoc/>
    public override string Name => Style.ToString();
}
