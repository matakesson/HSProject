namespace HSProject.Views;

public partial class StatsPage : ContentPage
{
	public StatsPage()
	{
		InitializeComponent();
		BindingContext = new ViewModels.StatsPageViewModel();
	}

    
}