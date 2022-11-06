using SolerSoft.Maui.Navigation;

namespace Suscito;

/// <summary>
/// The main shell for the application.
/// </summary>
public partial class AppShell : Shell
{
    #region Public Constructors

    /// <summary>
    /// Initializes a new <see cref="AppShell"/>.
    /// </summary>
    public AppShell()
    {
        InitializeComponent();
        RegisterRoutes();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

#if WINDOWS
        // HACK: hack due to https://github.com/dotnet/maui/issues/7227
        // Default to locked on Windows
        Shell.Current.FlyoutBehavior = FlyoutBehavior.Locked;
#endif
    }

    #endregion Public Constructors

    #region Private Methods

    /// <summary>
    /// Registers all potential page routes in the application.
    /// </summary>
    private void RegisterRoutes()
    {
        // Router.RegisterDetail<Model, ModelPage>();
    }

    #endregion Private Methods
}