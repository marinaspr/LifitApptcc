using LifitApp.Views;

namespace LifitApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnVerPostagensClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.PostagensPage());
    }
    private async void OnCriarClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CriarPostagem());
    }
}
