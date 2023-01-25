using SQLite;
using System;
using Saul_App.Conexion;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Saul_App.Paginas;

public partial class Musica : ContentPage
{
	public Musica()
	{
		InitializeComponent();
	}
	async void btnAgregar(object sender, EventArgs e)
	{
        if (!string.IsNullOrWhiteSpace(artista.Text) && !string.IsNullOrWhiteSpace(album.Text) && !string.IsNullOrWhiteSpace(genero.Text)
            && !string.IsNullOrWhiteSpace(rating.Text) && !string.IsNullOrWhiteSpace(release.Text))
        {
            
            await App.musicadatabase.SaveAlbum(new MusicaAtributos
            {
                Artista = artista.Text,
                Album = album.Text,
                Categoria= genero.Text,
                Rating = int.Parse(rating.Text),
                Release = int.Parse(release.Text)
            });
            artista.Text = string.Empty;
            album.Text = string.Empty;
            genero.Text = string.Empty;
            rating.Text = string.Empty;
            release.Text = string.Empty;
            colleciontView.ItemsSource = await App.musicadatabase.GetAlbums();
        }
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        colleciontView.ItemsSource = await App.musicadatabase.GetAlbums();
    }
}