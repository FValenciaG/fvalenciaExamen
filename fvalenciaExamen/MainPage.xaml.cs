
namespace fvalenciaExamen
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public static string[] Nombre = new string[] { "estudiante2024", "examen1", "fvalencia" };
        public static string[] Contrasena = new string[] { "uisrael2024", "parcial1", "2024" };

        public MainPage()
        {
            InitializeComponent();
          

        }

        private async void IngresarBtn_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtUsuario.Text) && !string.IsNullOrWhiteSpace(TxtContrasena.Text))
            {
                string nombreUsuario = TxtUsuario.Text;
                string contraseña = TxtContrasena.Text;

                if (ValidarInicioSesion(nombreUsuario, contraseña))
                  
  
                 await Navigation.PushAsync(new Registro(nombreUsuario));
                else
                    DisplayAlert("Error", "Nombre de usuario o contraseña incorrectos", "Aceptar");
            }
            else
                DisplayAlert("Error", "Por favor, completa todos los campos", "Aceptar");

        }
        public bool ValidarInicioSesion(string nombreUsuario, string contrasena)
        {
            for (int i = 0; i < Nombre.Length; i++)
            {
                if (nombreUsuario == Nombre[i] && contrasena == Contrasena[i])
                {
                    return true;
                }
            }
            return false;
        }

        private async void AcercaBtn_Clicked(object sender, EventArgs e)
        {
            string nombreUsuario = TxtUsuario.Text;
            await Navigation.PushAsync(new Acerca(nombreUsuario));
        }
    }
}
