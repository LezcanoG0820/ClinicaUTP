using ClinicaUTP.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaUTP.Services
{
    public class ServicioPaciente : IServicioPaciente
    {

        public SQLiteAsyncConnection _dbConnection;

        public ServicioPaciente()
        {
            SetupDatabase();
        }

        private async Task SetupDatabase()
        {
            if (_dbConnection == null)
            {
                string dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Pacientes.db3");
                _dbConnection = new SQLiteAsyncConnection(dbpath);
                await _dbConnection.CreateTableAsync<Paciente>();
            }
        }

        public async Task<int> AddPaciente(Paciente paciente)
        {
            await SetupDatabase();
            return await _dbConnection.InsertAsync(paciente);
        }

        public async Task<int> DeletePaciente(Paciente paciente)
        {
            await SetupDatabase();
            return await _dbConnection.DeleteAsync(paciente);
        }

        public async Task<int> UpdatePaciente(Paciente paciente)
        {
            await SetupDatabase();
            return await _dbConnection.UpdateAsync(paciente);
        }

        public async Task<List<Paciente>> GetListaPacientes()
        {
            await SetupDatabase();
            var listaPacientes = _dbConnection.Table<Paciente>().ToListAsync();
                return await listaPacientes;
        }

       
    }
}
