namespace Saul_App;
using Saul_App.Conexion;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
    private static MusicaDatabase musicaDatabase;
    public static MusicaDatabase musicadatabase
    {
        get
        {
            if (musicaDatabase == null)
            {
                musicaDatabase = new MusicaDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Musica.db3"));
            }
            return musicaDatabase;
        }
    }
}
