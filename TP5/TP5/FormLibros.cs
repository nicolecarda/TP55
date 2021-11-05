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
    public partial class FormLibros : Form
    {
        private LibroLogic _librologic;

        private Libro _libro;

       

        public FormLibros()
        {
            InitializeComponent();
            _librologic = new LibroLogic();
        }

       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                SaveLibro();
                this.ClearForm();
                this.Close();
                ((FormGrilla)this.Owner).CargarLibros();
            }

        }

        private bool Validar()
        {
        bool datoValido;
        datoValido = true;

          if (txtTitulo.Text.Trim() == "")
        {
        MessageBox.Show("Ingrese el titulo del libro");
        datoValido = false;
        txtTitulo.Focus();
        }

             if (txtAutor.Text.Trim() == "")
            {
        MessageBox.Show("Ingrese el autor del libro");
        datoValido = false;
        txtAutor.Focus();
          }

            if (txtEditorial.Text.Trim() == "")
              {
                  MessageBox.Show("Ingrese la editorial del libro");
                  datoValido = false;
                  txtEditorial.Focus();
             }


            if (txtLugar.Text.Trim() == "")
              {
                  MessageBox.Show("Ingrese la ciudad y país del libro");
                  datoValido = false;
                  txtLugar.Focus();
        
        }

            try
              {
                  Int32.Parse(txtPaginas.Text.Trim());
          }

            catch (Exception ex)
            {
                MessageBox.Show("Ingrese correctamente el número de páginas del libro");
                datoValido = false;
            }



            try
            {
                Int32.Parse(txtEdicion.Text.Trim());
            }

            catch (Exception ex2)
            {
                MessageBox.Show("Ingrese correctamente la edición del libro");
                datoValido = false;
            }


            try
            {
                Int32.Parse(txtISBN.Text.Trim());
            }

            catch (Exception ex3)
            {
                MessageBox.Show("Ingrese correctamente el ISBN del libro");
                datoValido = false;
            }






            return datoValido;


        }




    

        private void SaveLibro()
        {
                Libro libro = new Libro();
     
                libro.Titulo = txtTitulo.Text;
                libro.Autor = txtAutor.Text;
                libro.Paginas = Int32.Parse(txtPaginas.Text);
                libro.Edicion = Int32.Parse(txtEdicion.Text);
                libro.Editorial = txtEditorial.Text;
                libro.ISBN = Int32.Parse(txtISBN.Text);
                libro.FechaEdicion = txtFechaEdicion.Text;
                libro.Lugar = txtLugar.Text;

                libro.IdLibro = _libro != null ? _libro.IdLibro : 0;
                _librologic.GuardarLibro(libro);
                
                            

            }

            public void LoadLibro(Libro libro)
            {
            _libro = libro;

            if(libro != null)
            {
                ClearForm();

                txtTitulo.Text = string.Empty;
                txtAutor.Text = string.Empty;
                txtPaginas.Text = string.Empty;
                txtEdicion.Text = string.Empty;
                txtEditorial.Text = string.Empty;
                txtISBN.Text = string.Empty;
                txtFechaEdicion.Text = string.Empty;
                txtLugar.Text = string.Empty;
            }
        }

        private void ClearForm()
        {
            txtTitulo.Text = string.Empty;
            txtAutor.Text = string.Empty;
            txtPaginas.Text = string.Empty;
            txtEdicion.Text = string.Empty;
            txtEditorial.Text = string.Empty;
            txtISBN.Text = string.Empty;
            txtFechaEdicion.Text = string.Empty;
            txtLugar.Text = string.Empty;
        }

        

    }
}
