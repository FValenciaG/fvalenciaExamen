namespace fvalenciaExamen;

public partial class Registro : ContentPage
{
	public Registro(string nombreUsuario)
    {
        InitializeComponent();
        DisplayAlert("Informaci�n", "CONECTADO: " + nombreUsuario + " !", "Aceptar");
    }

    private void CalcularBtn_Clicked(object sender, EventArgs e)
    {

    }
}