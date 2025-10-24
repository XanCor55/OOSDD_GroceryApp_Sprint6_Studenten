using Grocery.App.ViewModels;

namespace Grocery.App.Views;

public partial class AfrekenenView : ContentPage
{

	

	public AfrekenenView(AfrekenenViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
    }
    public async void OnButtonClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Betaling", "Je hebt betaald!", "OK");
    }


    public void OnButtonClicked()
    {
        Console.WriteLine("Je hebt betaald");
    }

}