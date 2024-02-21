using System.Numerics;
using MauiApp1.Models;

namespace MauiApp1.Views;

public partial class PlanetDetailsPage : ContentPage
{
    public PlanetDetailsPage(Retsept retsept)
    {
        InitializeComponent();

        this.BindingContext = retsept;
    }

    async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}