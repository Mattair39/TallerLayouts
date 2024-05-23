using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace TallerLayouts;

public partial class AbsoluteLayout : ContentPage
{
	public AbsoluteLayout()
	{
		InitializeComponent();
	}
    private void GoToGridLayoutButton(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GridLayout());
    }
    
}