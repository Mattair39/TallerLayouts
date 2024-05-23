namespace TallerLayouts;

public partial class StackLayout : ContentPage
{
	public StackLayout()
	{
		InitializeComponent();
	}
    private void GoToFlexLayoutButton(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FlexLayout());
    }

}