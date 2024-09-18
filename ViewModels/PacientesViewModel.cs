using ClinicaUTP.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaUTP.Services;

namespace ClinicaUTP.ViewModels
{
    public partial class PacientesViewModel : ObservableObject
    {
      
        [RelayCommand]
        public async void AddUpdatePaciente()
        {
            await AppShell.Current.GoToAsync(nameof(AddPaciente));
        }
    }
}
