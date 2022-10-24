using SolerSoft.Maui.Mvvm;

namespace Suscito.Modules.AT.Pages;

public partial class ATHome : ViewPage<ATHomeVM>
{
	public ATHome()
	{
		EnsureViewModel();
		InitializeComponent();
	}
}