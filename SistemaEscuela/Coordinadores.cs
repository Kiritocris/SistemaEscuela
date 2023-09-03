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
    public partial class Coordinadores : Form
    {
        public Coordinadores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String dataname = Cname.Text;
            String dataedad = Cedad.Text;
            String datagrade = Cgrade.Text;

            string query = "INSERT INTO coordinadores (nombre,edad,grado_academico) " + "VALUES ('" + dataname + "', '" + dataedad + "', '" + datagrade + "')";
            MySqlConnection conexionDB = DBConnection.conexion();
            conexionDB.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(query, conexionDB);
                command.ExecuteNonQuery();
                MessageBox.Show("Coordinador registrado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al registrar coordinador: " + ex.Message);
            }
            finally
            {
                conexionDB.Close();
            }
        }
    }
}
