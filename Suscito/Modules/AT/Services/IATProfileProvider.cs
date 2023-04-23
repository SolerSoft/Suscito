namespace Suscito.Modules.AT
{
    /// <summary>
    /// A service that provides Attachment Theory profile data.
    /// </summary>
    public interface IATProfileProvider
    {
        #region Public Properties

        /// <summary>
        /// Gets the attachment profile for the users partner.
        /// </summary>
        ATProfile Partner { get; }

        /// <summary>
        /// Gets the attachment profile for the user.
        /// </summary>
        ATProfile User { get; }

        #endregion Public Properties
    }
}