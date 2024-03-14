using HSProject.Models;
using HSProject.ViewModels;

namespace HSProject.Views;

public partial class StatsPage : ContentPage
{
    private ViewModels.StatsPageViewModel _viewModel;
    static SearchedTeam team = SearchedTeam.GetInstance();

	public StatsPage()
	{
		InitializeComponent();
        string lastSearchedTeam = team.GetLastSearchedTeam();
        _viewModel = new ViewModels.StatsPageViewModel(lastSearchedTeam);
        BindingContext = _viewModel;
	}

	private async void OnSearchButtonClicked(object sender, EventArgs e)
	{
        _viewModel = new ViewModels.StatsPageViewModel(EntryTeam.Text);
        BindingContext = _viewModel;
        _viewModel.FetchStatsForTeam(EntryTeam.Text);
        team.SaveLastSearchedTeam(EntryTeam.Text);
        UpdateListView();
    }

    private async void SortByLastNameClicked(object sender, EventArgs e)
    {
        _viewModel.SortByLastName();
        UpdateListView();
    }

    private void SortByGoalsClicked(object sender, EventArgs e)
    {
        _viewModel.SortByGoals();
        UpdateListView();
    }

    private void SortByAssistsClicked(object sender, EventArgs e)
    {
        _viewModel.SortByAssists();
        UpdateListView();
    }

    private void SortByRatingClicked(object sender, EventArgs e)
    {
        _viewModel.SortByRating();
        UpdateListView();
    }
    private void UpdateListView()
    {
        var statsPageViewModel = BindingContext as ViewModels.StatsPageViewModel;
        if (statsPageViewModel != null)
        {
            StatsListView.ItemsSource = null;
            try
            {
                if(statsPageViewModel.Stats != null)
                {
                    StatsListView.ItemsSource = statsPageViewModel.Stats.skaters;
                }
            }
            catch (NullReferenceException)
            {
                StatsListView.ItemsSource = null;
            }
        }
    }
}

// Singleton pattern to save searched team
internal class SearchedTeam
{
    private static SearchedTeam _instance = new SearchedTeam();

    private string _lastSearchedTeam = "CAR";

    public static SearchedTeam GetInstance()
    {
        return _instance;
    }

    private SearchedTeam()
    {

    }

    public string GetLastSearchedTeam()
    {
        return _lastSearchedTeam;
    }

    public void SaveLastSearchedTeam(string team)
    {
        _lastSearchedTeam = team;
    }
}