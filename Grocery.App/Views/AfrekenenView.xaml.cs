using Grocery.App.ViewModels;

namespace Grocery.App.Views;

public partial class AfrekenenView : ContentPage
{
	public AfrekenenView(AfrekenenViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
    }
}