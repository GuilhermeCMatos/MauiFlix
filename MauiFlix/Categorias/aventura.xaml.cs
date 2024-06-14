using MauiFlix.Filmes.animacao;

namespace MauiFlix;

public partial class aventura : ContentPage
{
	public aventura()
	{
		InitializeComponent();
	}
    private void ImageButton_Clicked(object sender, EventArgs e)
    {

    }
    private void indianafilmbtn_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.aventura.indiana());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }

    }

    private void unchartedfilmbtn_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.aventura.uncharted());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void tombfilmbtn_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.aventura.tomb());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }

    }

    private void jurassicfilmbtn_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.aventura.jurassic());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }

    }
}