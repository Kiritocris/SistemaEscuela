using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using MySql.Data.MySqlClient;

namespace SistemaEscuela
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String dataname = fullname.Text;
            int dataage = int.Parse(age.Text);
            String datastreet = street.Text;
            String datanumber = number.Text;
            String datacity = city.Text;
            String dataphone = phone.Text;

            string query = "INSERT INTO alumnos (nombre_completo,edad,calle,numero,colonia,telefono) " + "VALUES ('" + dataname + "', '" + dataage + "', '" + datastreet + "','" + datanumber + "','" + datacity + "','" + dataphone + "')";
            MySqlConnection conexionDB = DBConnection.conexion();
            conexionDB.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(query, conexionDB);
                command.ExecuteNonQuery();
                MessageBox.Show("Alumno registrado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
            finally { 
            conexionDB.Close();
            }
        }
    }
}
