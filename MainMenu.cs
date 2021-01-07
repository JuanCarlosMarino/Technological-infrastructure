using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnologicalInfrastructure
{
    public partial class MainMenu : Form
    {
        public new Inicio Menu { get; set; } 
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {            
            Menu.Show();
            Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Signup Signup = new Signup();
            Hide();
            Signup.Menu = this;
            Signup.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            EditUser editUser = new EditUser();
            Hide();
            editUser.Menu = this;
            editUser.Show();
        }
    }
}
