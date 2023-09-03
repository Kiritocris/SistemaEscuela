﻿using CapaDatos;
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
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

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
                    while (reader.Read())
                    {
                        Bname.Visible = true;
                        Bedad.Visible = true;
                        Bcalle.Visible = true;
                        Bnumero.Visible = true;
                        Bcolonia.Visible = true;
                        Btelefono.Visible = true;
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
                }else {
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

        private void SearchDocente_Click(object sender, EventArgs e)
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
                    while (reader.Read())
                    {
                        Bname.Visible = true;
                        Bedad.Visible = true;
                        Bcalle.Visible = true;
                        Bnumero.Visible = true;
                        Sname.Visible = true;
                        Sedad.Visible = true;
                        Scalle.Visible = true;
                        Snumero.Visible = true;
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
    }
}
