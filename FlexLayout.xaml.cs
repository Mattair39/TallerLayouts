namespace TallerLayouts;

public partial class FlexLayout : ContentPage
{
	public FlexLayout()
	{
		InitializeComponent();
	}
    private void GoToAbsoluteLayoutButton(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AbsoluteLayout());
    }
}