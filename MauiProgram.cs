using ClinicaUTP.Services;
using ClinicaUTP.ViewModels;
using Microsoft.Extensions.Logging;

namespace ClinicaUTP
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            //Servicios
            builder.Services.AddSingleton<IServicioPaciente, ServicioPaciente>();

            //Vistas
            builder.Services.AddSingleton<ListaPacientes>();
            builder.Services.AddTransient<AddPaciente>();

            //ViewModels
            builder.Services.AddSingleton<PacientesViewModel>();
            builder.Services.AddTransient<AddPacienteViewModel>();



            return builder.Build();
        }
    }
}
