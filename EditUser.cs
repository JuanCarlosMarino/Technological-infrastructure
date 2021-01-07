using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnologicalInfrastructure.Controllers;
using TechnologicalInfrastructure.Entities;

namespace TechnologicalInfrastructure
{
    public partial class EditUser : Form
    {
        public new MainMenu Menu { get; set; }
        public EditUser()
        {
            InitializeComponent();
            cbUsuario.Items.AddRange(BD.cargarUsuarios());
        }

        private void txtSignUp_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackSignup_Click(object sender, EventArgs e)
        {
            Close();
            Menu.Show();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditUser_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            bool borrar = BD.borrarUsuario(cbUsuario.Text);
            if (borrar)
            {
                MessageBox.Show("ACCOUNT DELETED");
            }
            else
            {
                MessageBox.Show("ACCOUNT COULDN'T BE DELETED");
            }
            cbUsuario.Items.Clear();           
            cbUsuario.Items.AddRange(BD.cargarUsuarios());
            Close();
            Menu.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cbUsuario.Text.Length > 1)
            {
                updateUser updateUser = new updateUser();
                Hide();
                updateUser.Menu = this;
                Administrador administradoractual = BD.CargarUsuario(cbUsuario.Text);
                updateUser.Show();
            }
            else
            {
                MessageBox.Show("SELECT USER");
            }
            
        }
    }
}
