using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saul_App.Conexion
{
    public class MusicaDatabase
    {
        private readonly SQLiteAsyncConnection _database;
        public MusicaDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<MusicaAtributos>();
        }
        public Task<List<MusicaAtributos>> GetAlbums()
        {
            return _database.Table<MusicaAtributos>().ToListAsync();
        }
        public Task<int> SaveAlbum(MusicaAtributos musica)
        {
            return _database.InsertAsync(musica);
        }

        public Task<int> DeleteAll()
        {
            return _database.DeleteAllAsync<MusicaAtributos>();
        }
        public Task<int> DeleteAlbum(MusicaAtributos musica)
        {
            return _database.DeleteAsync(musica);
        }
    }
}
