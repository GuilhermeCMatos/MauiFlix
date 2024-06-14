namespace MauiFlix;

public partial class documentario : ContentPage
{
    public documentario()
    {
        InitializeComponent();
    }

    private void nossoplanetabtnfiml_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.documentario.nossoplaneta());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }

    }

    private void einsteinsbtnfiml_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.documentario.einstein());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }

    }

    private void vovozonabtnfiml_Clicked(object sender, EventArgs e)
    {
     
    }

    private void anjosbtnfiml_Clicked(object sender, EventArgs e)
    {
    }
}