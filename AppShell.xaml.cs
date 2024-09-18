namespace ClinicaUTP
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(AddPaciente), typeof(AddPaciente));
        }
    }
}
