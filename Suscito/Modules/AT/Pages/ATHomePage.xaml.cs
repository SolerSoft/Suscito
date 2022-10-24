using SolerSoft.Maui.Mvvm;

namespace Suscito.Modules.AT;

public partial class ATHomePage : ViewPage<ATHomeVM>
{
	public ATHomePage()
	{
		EnsureViewModel();
		InitializeComponent();
	}
}