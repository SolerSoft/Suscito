namespace Suscito.Modules.AT
{
    /// <summary>
    /// A test implementation of the <see cref="IATProfileProvider" /> service.
    /// </summary>
    public class TestATProfileProvider : IATProfileProvider
    {
        #region Private Fields

        private ATProfile partner;
        private ATProfile user;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes the <see cref="TestATProfileProvider" />.
        /// </summary>
        public TestATProfileProvider()
        {
            partner = new ATProfile()
            {
                // BowlbyStyle = BowlbyStyle.Avoidant
            };
            user = new ATProfile()
            {
                BowlbyStyle = BowlbyStyle.Anxious
            };
        }

        #endregion Public Constructors

        #region Public Properties

        /// <inheritdoc />
        public ATProfile Partner => partner;

        /// <inheritdoc />
        public ATProfile User => user;

        #endregion Public Properties
    }
}