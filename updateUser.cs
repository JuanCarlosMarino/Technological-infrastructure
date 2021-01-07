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
    public partial class updateUser : Form
    {
        public new EditUser Menu { get; set; }
        public updateUser()
        {
            InitializeComponent();
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnBackSignup_Click(object sender, EventArgs e)
        {
            Close();
            Menu.Show();
        }

        private void updateUser_Load(object sender, EventArgs e)
        {

        }
    }
}
