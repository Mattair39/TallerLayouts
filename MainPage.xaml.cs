namespace TallerLayouts
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void GoToGridLayoutButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridLayout());
        }
      
        private void GoToStackLayoutButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackLayout());
        }
        private void GoToFlexLayoutButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FlexLayout());
        }
        private void GoToAbsoluteLayoutButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AbsoluteLayout());
        }
    }

}
