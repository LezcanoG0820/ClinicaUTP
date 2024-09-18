using ClinicaUTP.Models;
using ClinicaUTP.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaUTP.ViewModels
{
    public partial class AddPacienteViewModel : ObservableObject
    {
        private readonly IServicioPaciente _ServicioPaciente;
        public AddPacienteViewModel(IServicioPaciente ServicioPaciente)
        {
            _ServicioPaciente = ServicioPaciente;
            pacienteDetails = new Paciente();

        }


        [ObservableProperty]
        public Paciente pacienteDetails;

        [RelayCommand]
        public async void AddPaciente()
        {
            var response = await _ServicioPaciente.AddPaciente(pacienteDetails);
            if (response > 0)
            {
                await Shell.Current.DisplayAlert("Paciente Agregado", "Detalles del paciente aceptados con exito", "OK");
            }
            else
            {
                await Shell.Current.DisplayAlert("Lo sentimos...", "Algo salio mal con los detalles del paciente", "OK");
            }
        }
    }
}
