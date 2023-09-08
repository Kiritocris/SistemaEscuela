using CapaDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscuela
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        public int tipo = 0;
        private void Search_Click(object sender, EventArgs e)
        {
            String clave = BClave.Text;
            MySqlDataReader reader = null;

            string query = "SELECT nombre_completo,edad,calle,numero,colonia,telefono FROM alumnos WHERE clave LIKE '" + clave + "' LIMIT 1";
            MySqlConnection conexionDB = DBConnection.conexion();
            conexionDB.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(query, conexionDB);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    tipo = 1;
                    while (reader.Read())
                    {

                        Bname.Visible = true;
                        Bedad.Visible = true;
                        Bcalle.Visible = true;
                        Bnumero.Visible = true;
                        Bcolonia.Visible = true;
                        Btelefono.Visible = true;
                        Sname.Text = "Nombre del alumno:";
                        Sedad.Text = "Edad del alumno:";
                        Scalle.Text = "Calle:";
                        Snumero.Text = "Numero:";
                        Scolonia.Text = "Colonia:";
                        Stelefono.Text = "Telefono:";
                        Sname.Visible = true;
                        Sedad.Visible = true;
                        Scalle.Visible = true;
                        Snumero.Visible = true;
                        Scolonia.Visible = true;
                        Stelefono.Visible = true;
                        Bname.Text = reader.GetString(0);
                        Bedad.Text = reader.GetString(1);
                        Bcalle.Text = reader.GetString(2);
                        Bnumero.Text = reader.GetString(3);
                        Bcolonia.Text = reader.GetString(4);
                        Btelefono.Text = reader.GetString(5);

                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
            finally
            {
                conexionDB.Close();
            }

        }

        private void SearchMateria_Click_1(object sender, EventArgs e)
        {
            String clave = clavemateria.Text;
            MySqlDataReader reader = null;
            string query = "SELECT nombre_materia,semestre,creditos FROM materias WHERE clave LIKE '" + clave + "' LIMIT 1";
            MySqlConnection conexionDB = DBConnection.conexion();
            conexionDB.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(query, conexionDB);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    tipo = 3;
                    while (reader.Read())
                    {
                        Bname.Visible = true;
                        Bedad.Visible = true;
                        Bcalle.Visible = true;
                        Bnumero.Visible = false;
                        Bcolonia.Visible = false;
                        Btelefono.Visible = false;
                        Sname.Text = "Nombre de la materia:";
                        Sedad.Text = "Semestre:";
                        Scalle.Text = "Creditos:";
                        Sname.Visible = true;
                        Sedad.Visible = true;
                        Scalle.Visible = true;
                        Snumero.Visible = false;
                        Scolonia.Visible = false;
                        Stelefono.Visible = false;
                        Bname.Text = reader.GetString(0);
                        Bedad.Text = reader.GetString(1);
                        Bcalle.Text = reader.GetString(2);

                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
            finally
            {
                conexionDB.Close();
            }
        }

        private void SearchCoordinador_Click_1(object sender, EventArgs e)
        {
            String clave = clavecoordinador.Text;
            MySqlDataReader reader = null;

            string query = "SELECT nombre,edad,grado_academico FROM coordinadores WHERE nombre LIKE '" + clave + "' LIMIT 1";
            MySqlConnection conexionDB = DBConnection.conexion();
            conexionDB.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(query, conexionDB);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    tipo = 4;
                    while (reader.Read())
                    {
                        Bname.Visible = true;
                        Bedad.Visible = true;
                        Bcalle.Visible = true;
                        Bnumero.Visible = false;
                        Bcolonia.Visible = false;
                        Btelefono.Visible = false;
                        Sname.Text = "Nombre del coordinador:";
                        Sedad.Text = "Edad:";
                        Scalle.Text = "Grado academico:";
                        Sname.Visible = true;
                        Sedad.Visible = true;
                        Scalle.Visible = true;
                        Snumero.Visible = false;
                        Scolonia.Visible = false;
                        Stelefono.Visible = false;
                        Bname.Text = reader.GetString(0);
                        Bedad.Text = reader.GetString(1);
                        Bcalle.Text = reader.GetString(2);

                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
            finally
            {
                conexionDB.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (tipo) {
                case 1:{
                        string query = "UPDATE alumnos SET nombre_completo='" + Bname.Text + "',edad='" + Bedad.Text + "',calle='" + Bcalle.Text + "',numero='" + Bnumero.Text + "',colonia='" + Bcolonia.Text + "',telefono='" + Btelefono.Text + "' WHERE clave='" + BClave.Text + "'";
                        MySqlConnection conexionDB = DBConnection.conexion();
                        conexionDB.Open();
                        try
                        {
                            MySqlCommand command = new MySqlCommand(query, conexionDB);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Registro actualizado");

                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Error al actualizar:" + ex.Message);
                        }
                        finally {
                            conexionDB.Close();
                        }


                        break;
                    }
                case 2: {
                        string query = "UPDATE docentes SET nombre='" + Bname.Text + "',apellido_paterno='" + Bedad.Text + "',apellido_materno='" + Bcalle.Text + "',telefono='" + Bnumero.Text + "' WHERE clave='" + clavedocente.Text + "'";
                        MySqlConnection conexionDB = DBConnection.conexion();
                        conexionDB.Open();
                        try
                        {
                            MySqlCommand command = new MySqlCommand(query, conexionDB);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Registro actualizado");

                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Error al actualizar:" + ex.Message);
                        }
                        finally
                        {
                            conexionDB.Close();
                        }
                        break;
                    }
                case 3: {
                        string query = "UPDATE materias SET nombre_materia='" + Bname.Text + "',semestre='" + Bedad.Text + "',creditos='" + Bcalle.Text + "' WHERE clave='" + clavemateria.Text + "'";
                        MySqlConnection conexionDB = DBConnection.conexion();
                        conexionDB.Open();
                        try
                        {
                            MySqlCommand command = new MySqlCommand(query, conexionDB);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Registro actualizado");

                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Error al actualizar:" + ex.Message);
                        }
                        finally
                        {
                            conexionDB.Close();
                        }
                        break;                    
                    }
                case 4: {
                        string query = "UPDATE coordinadores SET nombre='" + Bname.Text + "',edad='" + Bedad.Text + "',grado_academico='" + Bcalle.Text + "' WHERE nombre='" + clavecoordinador.Text + "'";
                        MySqlConnection conexionDB = DBConnection.conexion();
                        conexionDB.Open();
                        try
                        {
                            MySqlCommand command = new MySqlCommand(query, conexionDB);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Registro actualizado");

                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Error al actualizar:" + ex.Message);
                        }
                        finally
                        {
                            conexionDB.Close();
                        }
                        break;
                    }
                case 0:
                    {
                        MessageBox.Show("No ah ingresado ningun valor clave");
                        break;
                    }
            }
        }

        private void SearchDocente_Click_1(object sender, EventArgs e)
        {
            String clave = clavedocente.Text;

            MySqlDataReader reader = null;

            string query = "SELECT nombre,apellido_paterno,apellido_materno,telefono FROM docentes WHERE clave LIKE '" + clave + "' LIMIT 1";
            MySqlConnection conexionDB = DBConnection.conexion();
            conexionDB.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(query, conexionDB);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    tipo = 2;
                    while (reader.Read())
                    {
                        Bname.Visible = true;
                        Bedad.Visible = true;
                        Bcalle.Visible = true;
                        Bnumero.Visible = true;
                        Bcolonia.Visible = false;
                        Btelefono.Visible = false;
                        Sname.Text = "Nombre del docente:";
                        Sedad.Text = "Apellido paterno:";
                        Scalle.Text = "Apellido materno:";
                        Snumero.Text = "Telefono:";
                        Sname.Visible = true;
                        Sedad.Visible = true;
                        Scalle.Visible = true;
                        Snumero.Visible = true;
                        Scolonia.Visible = false;
                        Stelefono.Visible = false;
                        Bname.Text = reader.GetString(0);
                        Bedad.Text = reader.GetString(1);
                        Bcalle.Text = reader.GetString(2);
                        Bnumero.Text = reader.GetString(3);

                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
            finally
            {
                conexionDB.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (tipo)
            {
                case 1:
                    {
                        string query = "DELETE FROM alumnos WHERE clave='" + BClave.Text + "'";
                        MySqlConnection conexionDB = DBConnection.conexion();
                        conexionDB.Open();
                        try
                        {
                            MySqlCommand command = new MySqlCommand(query, conexionDB);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Registro eliminado");

                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Error al eliminar registro:" + ex.Message);
                        }
                        finally
                        {
                            conexionDB.Close();
                        }


                        break;
                    }
                case 2:
                    {
                        string query = "DELETE FROM docentes WHERE clave='" + clavedocente.Text + "'";
                        MySqlConnection conexionDB = DBConnection.conexion();
                        conexionDB.Open();
                        try
                        {
                            MySqlCommand command = new MySqlCommand(query, conexionDB);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Registro eliminado");

                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Error al eliminar registro:" + ex.Message);
                        }
                        finally
                        {
                            conexionDB.Close();
                        }
                        break;
                    }
                case 3:
                    {
                        string query = "DELETE FROM materias WHERE clave='" + clavemateria.Text + "'";
                        MySqlConnection conexionDB = DBConnection.conexion();
                        conexionDB.Open();
                        try
                        {
                            MySqlCommand command = new MySqlCommand(query, conexionDB);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Registro eliminado");

                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Error al eliminar registro:" + ex.Message);
                        }
                        finally
                        {
                            conexionDB.Close();
                        }
                        break;
                    }
                case 4:
                    {
                        string query = "DELETE FROM coordinadores WHERE nombre='" + clavecoordinador.Text + "'";
                        MySqlConnection conexionDB = DBConnection.conexion();
                        conexionDB.Open();
                        try
                        {
                            MySqlCommand command = new MySqlCommand(query, conexionDB);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Registro eliminado");

                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Error al eliminar registro:" + ex.Message);
                        }
                        finally
                        {
                            conexionDB.Close();
                        }
                        break;
                    }
                case 0:
                    {
                        MessageBox.Show("No ah ingresado ningun valor clave");
                        break;
                    }
            }
        }
    }
}
