namespace fvalenciaExamen;

public partial class Resumen : ContentPage
{
	public Resumen(string nombreUsuario)
	{

        InitializeComponent();
        txtUsuario.Text = nombreUsuario;    
    }
}