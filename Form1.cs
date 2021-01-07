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
using TechnologicalInfrastructure.Controllers;

namespace TechnologicalInfrastructure
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            
        }


        private void txtUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSession_Click(object sender, EventArgs e)
        {
            BD conexion = new BD();
            bool estado = BD.iniciarSesion(tbUsername.Text, tbPassword.Text);
            if (estado == true)
            {
                MainMenu mainMenu = new MainMenu();
                Hide();
                mainMenu.Menu = this;
                mainMenu.Show();
                tbUsername.Clear();
                tbPassword.Clear();
            }
            else
            {
                tbPassword.Clear();
            }            
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
