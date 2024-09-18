using ClinicaUTP.ViewModels;

namespace ClinicaUTP;

public partial class ListaPacientes : ContentPage
{
	public PacientesViewModel _viewmodel;
	public ListaPacientes(PacientesViewModel viewModel)
	{
		InitializeComponent();
		_viewmodel = viewModel;
		this.BindingContext = viewModel;

	}


    protected override void OnAppearing()
    {
        base.OnAppearing();
		{

		}
    }



}