using ClinicaUTP.ViewModels;

namespace ClinicaUTP;

public partial class AddPaciente : ContentPage
{
	public AddPaciente(AddPacienteViewModel viewModel)
	{
        InitializeComponent();

		this.BindingContext = viewModel;
	}

    
}