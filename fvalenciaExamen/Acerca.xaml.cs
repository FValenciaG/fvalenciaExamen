using static System.Runtime.InteropServices.JavaScript.JSType;

namespace fvalenciaExamen;

public partial class Acerca : ContentPage
{
	public Acerca(string nombreUsuario)
	{
        InitializeComponent();
        DisplayAlert("Información", "BIENVENIDO: " + nombreUsuario + " !", "Aceptar");
    }
}