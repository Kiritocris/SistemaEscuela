using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;


namespace SistemaEscuela
{
    public partial class Tablero : Form
    {
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public Tablero()
        {
            InitializeComponent();
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario) { 
        
            if(MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if(FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.LightGray;

            contenedor.Controls.Add(formulario);
            formulario.Show();
        
        }

        private void Menualta_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Alta());
        }

        private void Menualumnos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Update());
        }

        private void Menudocentes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Docentes());
        }

        private void Menumaterias_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Materias());
        }

        private void Menucoord_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Coordinadores());
        }

        private void IconMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Buscar());
        }
    }
}
