using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace TP5
{
    class LibroDatos
    {
        SqlConnection cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TP5 PV;Data Source=PCLAURA\\SQLEXPRESS");
   
    public void InsertLibro(Libro libro)

        {
            try
            {
                cn.Open();

                string query = "INSERT INTO Libros (Titulo, Autor, Paginas, Edicion, Editorial, ISBN, FechaEdicion, Lugar) VALUES (@Titulo, @Autor, @Paginas, @Edicion, @Editorial, @ISBN, @FechaEdicion, @Lugar)";

                SqlParameter titulo = new SqlParameter();
                titulo.ParameterName = "@titulo";
                titulo.Value = libro.Titulo;
                titulo.DbType = System.Data.DbType.String;
                SqlParameter autor = new SqlParameter("@autor", libro.Autor);
                SqlParameter paginas = new SqlParameter("@paginas", libro.Paginas);
                SqlParameter edicion = new SqlParameter("@edicion", libro.Edicion);
                SqlParameter editorial = new SqlParameter("@editorial", libro.Editorial);
                SqlParameter ISBN = new SqlParameter("@ISBN", libro.ISBN);
                SqlParameter fechaedicion = new SqlParameter("@fechaedicion", libro.FechaEdicion);
                SqlParameter lugar = new SqlParameter("@lugar", libro.Lugar);
                SqlCommand comando = new SqlCommand(query, cn);
                comando.Parameters.Add(titulo);
                comando.Parameters.Add(autor);
                comando.Parameters.Add(paginas);
                comando.Parameters.Add(edicion);
                comando.Parameters.Add(editorial);
                comando.Parameters.Add(ISBN);
                comando.Parameters.Add(fechaedicion);
                comando.Parameters.Add(lugar);
                comando.ExecuteNonQuery();
            }

            catch (Exception)
            {

                throw;
            }
            
            finally
            {
                cn.Close();
            }
        }

        public List<Libro> GetLibro(string buscar = null)
        {
           
            List<Libro> libros = new List<Libro>();
            try
            {
                cn.Open();
                string query = @"SELECT IdLibro,Titulo,Autor,Paginas,Edicion, Editorial, ISBN, FechaEdicion, Lugar
                                   FROM Libros";
                SqlCommand comando = new SqlCommand();
                if (!string.IsNullOrEmpty(buscar))
                {
                    
                    query += @" WHERE Titulo LIKE @Buscar OR Autor LIKE @Buscar OR Paginas LIKE @Buscar OR Edicion LIKE @Buscar OR Editorial LIKE @Buscar OR ISBN LIKE @Buscar OR FechaEdicion LIKE @Buscar OR Lugar LIKE @Buscar";

                    
                    comando.Parameters.Add(new SqlParameter("@Buscar", $"%{buscar}%"));
                }

                comando.CommandText = query;
                comando.Connection = cn;

                
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                  
                    libros.Add(new Libro
                    {
                        IdLibro = int.Parse(reader["IdLibro"].ToString()),
                        Titulo = reader["Titulo"].ToString(),
                        Autor = reader["Autor"].ToString(),
                        Paginas = int.Parse(reader["Paginas"].ToString()),
                        Edicion = int.Parse(reader["Edicion"].ToString()),
                        Editorial = reader["Editorial"].ToString(),
                        ISBN = int.Parse(reader["ISBN"].ToString()),
                        FechaEdicion = reader["FechaEdicion"].ToString(),
                        Lugar = reader["Lugar"].ToString(),

                    });
                }
                


            }
            catch (Exception e)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return libros;

        }

        public void UpdateLibro(Libro libro)
        {
            try
            {
                
                cn.Open();

                string query = @"
                                 UPDATE  Libros
                       SET Titulo=@Titulo, Autor = @Autor, Paginas = @Paginas, Edicion = @Edicion, Editorial = @Editorial, ISBN = @ISBN, FechaEdicion = @FechaEdicion, Lugar = @Lugar
                          WHERE IdLibro=@idLibro";
               

                SqlParameter id = new SqlParameter("@idLibro", libro.IdLibro);
                SqlParameter titulo = new SqlParameter("@titulo", libro.Titulo);
                SqlParameter autor = new SqlParameter("@autor", libro.Autor);
                SqlParameter paginas = new SqlParameter("@paginas", libro.Paginas);
                SqlParameter edicion = new SqlParameter("@edicion", libro.Edicion);
                SqlCommand comando = new SqlCommand(query, cn);
                comando.Parameters.Add(titulo);
                comando.Parameters.Add(autor);
                SqlParameter fechaedicion = new SqlParameter("@fechaedicion", libro.FechaEdicion);
                SqlParameter lugar = new SqlParameter("@lugar", libro.Lugar);
                SqlParameter editorial = new SqlParameter("@editorial", libro.Editorial);
                SqlParameter ISBN = new SqlParameter("@ISBN", libro.ISBN);
                comando.Parameters.Add(paginas);
                comando.Parameters.Add(edicion);
                comando.Parameters.Add(editorial);
                comando.Parameters.Add(ISBN);
                comando.Parameters.Add(fechaedicion);
                comando.Parameters.Add(lugar);
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
            }
           
            finally
            {
                cn.Close();
            }
        }
        public void BorrarLibro(int id)

        {
            try
            {
                
                cn.Open();

                
                string query = @"
                                 DELETE FROM Libros WHERE IdLibro=@idLibro";
                
                SqlCommand comando = new SqlCommand(query, cn);
                
                comando.Parameters.Add(new SqlParameter("@idLibro", id));

                
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                throw;
            }
       
            finally
            {
                cn.Close();
            }


        }
    }
}
