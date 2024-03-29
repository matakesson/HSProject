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

        private async void OnGamesButtonClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            string date = button.Text.ToLower(); 
            
            BindingContext = new MainPageViewModel(date);
        }

        private async void OnClickedGoToStandings(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.StandingsPage());
        }
    }

}
