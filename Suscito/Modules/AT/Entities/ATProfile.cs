using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suscito.Modules.AT
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
    /// Represents the Attachment Theory profile of an individual.
    /// </summary>
    public class ATProfile
    {
        /// <summary>
        /// Gets or sets the persons Bowlby attachment style.
        /// </summary>
        public BowlbyStyle BowlbyStyle { get; set; }

        /// <summary>
        /// Gets a value that indicates if the profile styles are unknown.
        /// </summary>
        public bool IsUnknown 
        {
            get
            {
                return BowlbyStyle == BowlbyStyle.Unknown;
            }
        }
    }
}
