using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saul_App.Conexion
{
    public class MusicaAtributos
    {
        [PrimaryKey,AutoIncrement] 
        public int Id { get; set; }
        public string Artista { get; set; }
        public string Album { get; set; }
        public string Categoria { get; set; }
        public double Rating { get; set; }
        public int Release { get; set;}
    }
}
