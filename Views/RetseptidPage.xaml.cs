using System.Numerics;
using MauiApp1.Models;
using MauiApp1.Services;
using Views;

namespace MauiApp1.Views;

public partial class RetseptidPage : ContentPage
{
    private const int AnimationDuration = 800;

    public RetseptidPage()
    {
        InitializeComponent();

        lstPopularRetseptid.ItemsSource = RetseptServices.GetFeaturedRetseptid();
        lstAllRetseptid.ItemsSource = RetseptServices.GetAllRetseptid();
    }

    async void GridArea_Tapped(System.Object sender, System.EventArgs e)
    {

    }

    async void ProfilePic_Clicked(System.Object sender, System.EventArgs e)
    {
        // Reveal our menu and move the main content out of the view
        _ = MainContentGrid.TranslateTo(-this.Width * 0.5, this.Height * 0.1, AnimationDuration, Easing.CubicIn);
        await MainContentGrid.ScaleTo(0.8, AnimationDuration);
        _ = MainContentGrid.FadeTo(0.8, AnimationDuration);
    }

    async void Planets_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new PlanetDetailsPage(e.CurrentSelection.First() as Retsept));
    }
}