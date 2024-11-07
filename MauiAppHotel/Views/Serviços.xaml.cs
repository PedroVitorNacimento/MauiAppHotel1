namespace MauiAppHotel.Views;

public partial class Serviços : ContentPage
{
	public Serviços()
	{
		InitializeComponent();
	}

    private  async void Button_Clicked_voltar(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ContratacaoHospedagem());
    }

}