namespace TallerLayouts;

public partial class GridLayout : ContentPage
{
	public GridLayout()
	{
		InitializeComponent();
	}
    private void GoToStackLayoutButton(object sender, EventArgs e)
    {
        Navigation.PushAsync(new StackLayout());
    }
}
