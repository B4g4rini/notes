namespace notes.ui.Views;

public partial class Sobre : ContentPage
{
    public Sobre()
    {
        InitializeComponent();
    }

    private async void SaibaMais_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.Sobre sobre)
            await Launcher.Default.OpenAsync(sobre.MaisInfoURL);
        // await DisplayAlert("Site", "Site da Microsoft aberto!", "Ok");
    }
}