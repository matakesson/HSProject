namespace HSProject.Views;

public partial class SchedulePage : ContentPage
{
	public SchedulePage()
	{
		InitializeComponent();
		BindingContext = new ViewModels.SchedulePageViewModel();
	}

    private async void OnScheduleViewGameSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var game = ((ListView)sender).SelectedItem as Models.Game;

        if (game != null)
        {
            var page = new ScoreDetailsPage();
            page.BindingContext = game;
            await Navigation.PushAsync(page);
        }
    }

    
}