using ClinicaUTP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaUTP.Services
{
    public interface IServicioPaciente
    {
        Task<List<Paciente>> GetListaPacientes();

        Task<int> AddPaciente(Paciente paciente);
        Task<int> DeletePaciente(Paciente paciente);
        Task<int> UpdatePaciente(Paciente paciente);

    }
}
