using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5
{
    public partial class FormGrilla : Form
    {

        private LibroLogic _librologic;
        public FormGrilla()
        {
            InitializeComponent();
            _librologic = new LibroLogic();
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormLibros formlibros = new FormLibros();
            formlibros.ShowDialog(this);
        }

        private void FormGirlla_Load(object sender, EventArgs e)
        {
            CargarLibros();
        }

        //Carga contactos de la base de datos en la grilla
        public void CargarLibros(String SearchText = null)
        {
            List<Libro> libros = _librologic.GetLibro(SearchText);
            GridLibros.DataSource = libros;

        }

       
            
            
        private void BorrarLibro(int idLibro)
        {
            _librologic.BorrarLibro(idLibro);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarLibros(txtBuscar.Text);
            txtBuscar.Text = string.Empty;
        }

        private void GridLibros_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)GridLibros.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "Editar")
            {

                FormLibros formlibros = new FormLibros();

                formlibros.LoadLibro(new Libro
                {
                    IdLibro = int.Parse(GridLibros.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    Titulo = GridLibros.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Autor = GridLibros.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Paginas = int.Parse(GridLibros.Rows[e.RowIndex].Cells[3].Value.ToString()),
                    Edicion = int.Parse(GridLibros.Rows[e.RowIndex].Cells[4].Value.ToString()),
                    Editorial = GridLibros.Rows[e.RowIndex].Cells[5].Value.ToString(),
                    ISBN = int.Parse(GridLibros.Rows[e.RowIndex].Cells[6].Value.ToString()),
                    FechaEdicion = GridLibros.Rows[e.RowIndex].Cells[7].Value.ToString(),
                    Lugar = GridLibros.Rows[e.RowIndex].Cells[8].Value.ToString(),
                });

                formlibros.ShowDialog(this);
            }

            else if (cell.Value.ToString() == "Eliminar")
            {
                BorrarLibro(int.Parse((GridLibros.Rows[e.RowIndex].Cells[0]).Value.ToString()));
                CargarLibros();

            
        }

    }
}
}
