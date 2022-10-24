
namespace Suscito.Modules.AT.Controls;

public partial class StyleInfoCard : ContentView
{
    public static readonly BindableProperty StyleInfoProperty = BindableProperty.Create(nameof(StyleInfo), typeof(StyleInfo), typeof(StyleInfoCard), null);

    public StyleInfoCard()
	{
		InitializeComponent();
	}

    public StyleInfo StyleInfo
    {
        get => (StyleInfo)GetValue(StyleInfoProperty);
        set => SetValue(StyleInfoProperty, value);
    }

}