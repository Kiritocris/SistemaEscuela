using CapaDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscuela
{
    public partial class Docentes : Form
    {
        public Docentes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String dataname = Dname.Text;
            String dataapellido = Dapellido.Text;
            String dataapellidop = Dapellidop.Text;
            String dataphone = Dtelefono.Text;
            

            string query = "INSERT INTO docentes (nombre,apellido_paterno,apellido_materno,telefono) " + "VALUES ('" + dataname + "', '" + dataapellido + "', '" + dataapellidop + "','" + dataphone+ "')";
            MySqlConnection conexionDB = DBConnection.conexion();
            conexionDB.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(query, conexionDB);
                command.ExecuteNonQuery();
                MessageBox.Show("Docente registrado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al registrar docente: " + ex.Message);
            }
            finally
            {
                conexionDB.Close();
            }
        }
    }
}
