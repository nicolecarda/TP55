using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    class LibroLogic
    {
        private LibroDatos _librodatos;

        public LibroLogic ()
        {
            _librodatos = new LibroDatos();
        }

    

    public Libro GuardarLibro (Libro libro)
    {
        if (libro.IdLibro == 0)

            _librodatos.InsertLibro(libro);

        else
        {
            _librodatos.UpdateLibro(libro);
        }

        return libro;

    }

    public List<Libro> GetLibro(string txtBuscar = null)

    {

        return _librodatos.GetLibro(txtBuscar);

    }

    public void BorrarLibro(int idLibro)
    {

        _librodatos.BorrarLibro(idLibro);

    }

}
}