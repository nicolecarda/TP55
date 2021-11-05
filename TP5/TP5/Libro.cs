using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5
{
    public class Libro
    {
        public int IdLibro { get; set; }
        public string Titulo {get; set;}
        public string Autor { get; set; }
        public int Paginas { get; set; }
        public int Edicion { get; set; }
        public string Editorial { get; set; }
        public int ISBN { get; set; }
        public string FechaEdicion { get; set; }
        public string Lugar { get; set; }

    }
}