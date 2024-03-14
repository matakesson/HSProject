namespace HSProject.Views;

public partial class StandingsPage : ContentPage
{
    private ViewModels.StandingsPageViewModel _viewModel;

    public StandingsPage()
    {
        InitializeComponent();
        _viewModel = new ViewModels.StandingsPageViewModel();
        BindingContext = _viewModel;

    }

}