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
    public partial class Signup : Form
    {
        public new MainMenu Menu { get; set; }
        public Signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBackSignup_Click(object sender, EventArgs e)
        {
            Close();
            Menu.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            BD bd = new BD();
            bool estado = false;
            Administrador administrador = new Administrador();
            String mensaje = "The following fields are incorrect:";
            int contador = 9;
            estado = Administrador.validarNombre(tbNombre.Text);
            if (estado == false)
            {
                mensaje += "\nName";
                tbNombre.Clear();
                contador--;
            }
            estado = Administrador.validarApellido(tbApellido.Text);
            if (estado == false)
            {
                mensaje += "\nLast name";
                tbApellido.Clear();
                contador--;
            }
            estado = Administrador.validarDocumento(tbDocumento.Text);
            if (estado == false)
            {
                mensaje += "\nDocument";
                tbDocumento.Clear();
                contador--;
            }
            estado = Administrador.validarCorreo(tbCorreo.Text);
            if (estado == false)
            {
                mensaje += "\nEmail";
                tbCorreo.Clear();
                contador--;
            }
            estado = Administrador.validarCelular(tbCelular.Text);
            if (estado == false)
            {
                mensaje += "\nPhone number";
                tbCelular.Clear();
                contador--;
            }
            estado = Administrador.validarUsuario(tbUsuario.Text);
            if (estado == false)
            {
                mensaje += "\nUsername";
                tbUsuario.Clear();
                contador--;
            }
            estado = Administrador.validarContrasenia(BD.GetMD5(tbContrasena.Text));
            if (estado == false)
            {
                mensaje += "\nPassword";
                tbContrasena.Clear(); 
                tbContrasena2.Clear();
                contador--;
            }
            if (estado == true && tbContrasena.Text != tbContrasena2.Text)
            {
                mensaje += "\nThe passwords dont match";
                tbContrasena.Clear();
                tbContrasena2.Clear();
                contador--;
            }
            if (estado == false && tbContrasena.Text != tbContrasena2.Text)
            {
                mensaje += "\nThe passwords dont match";
                tbContrasena.Clear();
                tbContrasena2.Clear();
                contador--;
            }
            if (contador != 9)
            {
                MessageBox.Show(mensaje);
            }
            else
            {
                administrador.Nombre = tbNombre.Text;
                administrador.Apellido = tbApellido.Text;
                administrador.Documento = tbDocumento.Text;
                administrador.Correo = tbCorreo.Text;
                administrador.Celular = tbCelular.Text;
                administrador.Usuario = tbUsuario.Text;
                administrador.Contrasenia = BD.GetMD5(tbContrasena.Text);
                if (BD.validarUsuario(administrador.Usuario))
                {
                    bool registro = BD.RegistrarUsuario(administrador);
                    if (registro == true)
                    {
                        MessageBox.Show("ACCOUNT CREATED");
                        Close();
                        Menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("FAILED TO CREATE ACCOUNT");
                    }
                }
                else
                {
                    MessageBox.Show("USERNAME ALREADY TAKEN");
                    tbUsuario.Clear();
                }
                
            }            

        }

        private void txtContrasena2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtContrasena_Click(object sender, EventArgs e)
        {

        }

        private void txtCelular_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreo_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_Click(object sender, EventArgs e)
        {

        }

        private void tbContrasena2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSignUp_Click(object sender, EventArgs e)
        {

        }

        private void tbContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
