﻿using HSProject.ViewModels;
using HSProject.Views;

namespace HSProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.MainPageViewModel("today");
        }

        
        private async void OnClickedGoToStats(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.StatsPage());
        }

        private async void OnClickedGoToSchedule(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.SchedulePage());
        }

        private async void OnScoreSummaryGameSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var game = ((ListView)sender).SelectedItem as Models.Game;

            if (game != null)
            {
                var page = new BoxScorePage();
                page.BindingContext = game;
                await Navigation.PushAsync(page);
            }
        }

        private async void OnClickedYesterdayGames(object sender, EventArgs e)
        {
            InitializeComponent();
            BindingContext = new ViewModels.MainPageViewModel("yesterday");
        }

        private void OnClickedTodayGames(object sender, EventArgs e)
        {
            InitializeComponent();
            BindingContext = new ViewModels.MainPageViewModel("today");
        }

        private void OnClickedTomorrowGames(object sender, EventArgs e)
        {
            InitializeComponent();
            BindingContext = new ViewModels.MainPageViewModel("tomorrow");
        }
    }

}