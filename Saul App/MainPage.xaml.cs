using Saul_App.Paginas;
namespace Saul_App;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
	}
	private void btnCine(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Cine());
	}
    private void btnMusica(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Musica());
    }
    private void btnLibros(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Libros());
    }
    private void btnEjercicio(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Ejercicio());
    }

}

