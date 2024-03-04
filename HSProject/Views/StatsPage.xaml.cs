using HSProject.Models;
using HSProject.ViewModels;

namespace HSProject.Views;

public partial class StatsPage : ContentPage
{
    private ViewModels.StatsPageViewModel viewModel;

	public StatsPage()
	{
		InitializeComponent();
        viewModel = new ViewModels.StatsPageViewModel("CAR");
        BindingContext = viewModel;
	}

	private async void OnSearchButtonClicked(object sender, EventArgs e)
	{
		BindingContext = new ViewModels.StatsPageViewModel(EntryTeam.Text);
    }

    private async void SortByLastNameClicked(object sender, EventArgs e)
    {
        viewModel.SortByLastName();
        if (!string.IsNullOrEmpty(EntryTeam.Text))
        {
            BindingContext = new StatsPageViewModel(EntryTeam.Text);
        }
        else
        {
            BindingContext = new StatsPageViewModel("CAR");
            int i = 0;
        }
    }

    private void SortByGoalsClicked(object sender, EventArgs e)
    {
        //viewModel.SortByGoals();
    }

    private void SortByAssistsClicked(object sender, EventArgs e)
    {
        //viewModel.SortByAssist();
    }

    private void SortByRatingClicked(object sender, EventArgs e)
    {
        //viewModel.SortByRating();
    }
    
}