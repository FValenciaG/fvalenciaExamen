namespace fvalenciaExamen;

public partial class Registro : ContentPage
{
	public Registro(string nombreUsuario)
    {
        InitializeComponent();
        DisplayAlert("Información", "CONECTADO: " + nombreUsuario + " !", "Aceptar");
    }

    private void CalcularBtn_Clicked(object sender, EventArgs e)
    {

    }
}