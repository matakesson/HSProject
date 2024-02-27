namespace HSProject.Views;

public partial class BoxScorePage : ContentPage
{
    

	public BoxScorePage()
	{
		InitializeComponent();
	}

    private async void OnClickedGoToStats(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.StatsPage());
    }

    private async void OnClickedGoToSchedule(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.SchedulePage());
    }
}