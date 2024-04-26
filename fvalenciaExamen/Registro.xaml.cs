namespace fvalenciaExamen;

public partial class Registro : ContentPage
{
	public Registro(string nombreUsuario)
    {
        InitializeComponent();
        TxtUsuario.Text = nombreUsuario;

    }

    private void CalcularBtn_Clicked(object sender, EventArgs e)
    {

    }
}