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
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String dataname = Dname.Text;
            String datasemester = Dsemester.Text;
            String datacredito = Dcredito.Text;
            
            string query = "INSERT INTO materias (nombre_materia,semestre,creditos) " + "VALUES ('" + dataname + "', '" + datasemester + "', '" + datacredito + "')";
            MySqlConnection conexionDB = DBConnection.conexion();
            conexionDB.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(query, conexionDB);
                command.ExecuteNonQuery();
                MessageBox.Show("Materia registrada");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al registrar materia: " + ex.Message);
            }
            finally
            {
                conexionDB.Close();
            }
        }
    }
}
